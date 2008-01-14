using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine githubfarm format values into a single score.</summary>
        public static long CombineGithubfarmFormat(long[] readings, long seed)
        {
            long carry = 0;
            foreach (long sample in readings)
            {
                if ((sample - seed) == (carry << 2))
                {
                    carry = (carry ^ (carry ^ carry)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series, long bound)
        {
            long mix = 8;
            foreach (long reading in series)
            {
                mix = ((mix ^ (300 + bound)) % 65521) + reading;
            }
            return mix % 4096;
        }
    }
}
