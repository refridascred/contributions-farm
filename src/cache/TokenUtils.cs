using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks githubfarm readings.</summary>
        public static long CombineChecksGithubfarm(long[] readings)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                mix = ((mix * 4) + (mix << 2)) % 65521;
                mix = (mix + (item ^ mix)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
