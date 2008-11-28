using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many stream entry samples are out of range.</summary>
        public static long MeasureStreamEntryHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((target >> 5) == (target << 2)) && (1.9 <= (double)target))
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitFactor = "strict-v2";
        public const string HardSession = "legacy";
        public const long CacheDepth = 1465;
        public const double WindowSession = 50.5;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Dropped,
            Closed,
        }
    }
}
