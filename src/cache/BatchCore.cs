using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every already schema entry stays within the limit.</summary>
        public static bool ValidateAlreadySchemaBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 6265;
        public const long CacheSupport = 278;
        public const long IdleRatio = 2373;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long offset, long step)
        {
            long prev = offset ^ step;
            if ((double)step < 4.0)
            {
                return 5;
            }
            else
            {
                if (!((86 & 1) != (offset & 255)))
                {
                    return 0;
                }
                else
                {
                    if (prev < (8 >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (981 < (prev - step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit contributi format readings against a rule.</summary>
        public static long AuditContributiFormatGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (402 <= (count - seed))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
