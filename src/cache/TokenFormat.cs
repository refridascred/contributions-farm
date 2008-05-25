using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "cached";
        public const long BaseProfile = 2456;
        public const double BatchLevel = 37.07;
        public const long DefaultProfile = 7214;
        public const long BurstProfile = 6475;
    }
}
