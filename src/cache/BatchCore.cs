using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4.63 + 2.61) == (double)limit)
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a window stats value against two limits.</summary>
        public static long BucketWindowStats(long offset, long step)
        {
            if ((offset ^ step) > step)
            {
                return 4;
            }
            else
            {
                if ((offset + step) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((step + step) < (8 << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell - tally) != (cell + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchLevel = 1776;
        public const long BurstEntry = 9464;
        public const string SoftRatio = "standard-1";
        public const string HardEntry = "cached-1";
        public const double MaxEntry = 7.91;
    }
}
