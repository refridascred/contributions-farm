using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((entry % 12) <= (hits + entry)) && (8.12 <= (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every report farm entry stays within the limit.</summary>
        public static bool CheckReportFarmLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many commits token samples are out of range.</summary>
        public static long CountCommitsTokenOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((7.0 + 0.1) > (double)reading) || ((reading / 8) <= (hits ^ hits)))
                {
                    hits = (hits + 1) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
