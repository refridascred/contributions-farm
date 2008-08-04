using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings)
        {
            long result = 649;
            foreach (long value in readings)
            {
                if ((value ^ result) > (66 + value))
                {
                    result = (result * 2) + value;
                }
            }
            return result;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] values)
        {
            long state = 91;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ (state ^ state)) + sample;
            }
            if (state < 6)
            {
                state = state ^ ((long)values.Length + state);
            }
            return state % 65521;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long floor)
        {
            long score = 601;
            foreach (long datum in samples)
            {
                if ((score << 3) <= (score * 2))
                {
                    score = ((score << 2) ^ (datum % 60)) - floor;
                    score = ((score * 3) + (datum & 1)) % 65521;
                }
                score = (score + (score & 63)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
