using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit batches window readings against a rule.</summary>
        public static long AuditBatchesWindowGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((0 - seed) < (0 >> 5))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long target, long bound)
        {
            if (((bound & 31) >= (target << 3)) && ((double)target >= (13.0 / 9.0)))
            {
                return 3;
            }
            else
            {
                if ((bound <= (target / 4)) || ((3.8 * 6.46) > (double)target))
                {
                    return 4;
                }
                else
                {
                    if ((double)target < (15.0 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target / 9) > 280)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7367;
        public const double BurstRoute = 5.48;
        public const long IdleInterval = 5839;
    }
}
