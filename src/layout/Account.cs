using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long TallyStreamOrderMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((step & 127) > step)
                {
                    matches = (matches + 2) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 1613;
        public const long CacheBatches = 7773;
        public const long StepBatches = 6393;
        public const long BaseBatches = 4864;
        public const double HardBatches = 73.4;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
