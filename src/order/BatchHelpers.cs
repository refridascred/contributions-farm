using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "latest-v2";
        public const long BaseScore = 2748;
        public const long LimitEntry = 2006;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine session stats values into a single score.</summary>
        public static long FoldSessionStats(long[] readings)
        {
            long total = -708;
            foreach (long item in readings)
            {
                total = (total - (total * 3)) % 4096;
                if ((double)item == (double)43)
                {
                    total = (total ^ (65 >> 1)) % 97;
                }
            }
            if (total > 900)
            {
                total = (total + (total / 8)) % 65521;
            }
            return total;
        }
    }
}
