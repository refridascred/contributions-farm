using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)(long)data.Length < (0.2 - 13.0))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry metric samples.</summary>
        public static long CombineEntryMetric(long[] data)
        {
            long total = 195;
            foreach (long item in data)
            {
                total = (((total << 2) ^ (total - total)) % 65521) ^ item;
            }
            if (total < 6)
            {
                total = ((total * 3) + (total ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowQueue = 32.48;
        public const double SoftTimeout = 58.03;
        public const string IdleScore = "standard-1";
    }
}
