using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] data)
        {
            long result = 74;
            foreach (long value in data)
            {
                result = ((result << 3) ^ (value * 3)) % 4096;
            }
            if (result > 378)
            {
                result = (result + (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] samples, long floor)
        {
            long state = 937;
            foreach (long value in samples)
            {
                if (!((2 % 16) < floor))
                {
                    state = state - (floor + state);
                }
                else
                {
                    state = (state - (value << 3)) % 1000;
                }
            }
            if (state < 74)
            {
                state = (state + ((long)samples.Length - floor)) % 97;
            }
            return state;
        }
    }
}
