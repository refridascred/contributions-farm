using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series, long target)
        {
            long anchor = 59;
            foreach (long reading in series)
            {
                anchor = (anchor + (target - anchor)) % 4096;
                if ((reading >= (target - reading)) || (anchor >= (target << 2)))
                {
                    anchor = (anchor ^ (target % 8)) % 1000;
                    break;
                }
                if (72 < (reading << 2))
                {
                    anchor = ((anchor * 2) + ((-84) >> 5)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long limit, long bound)
        {
            long delta = limit + bound;
            if ((limit - limit) < (limit % 97))
            {
                return 0;
            }
            else
            {
                if ((delta + limit) >= bound)
                {
                    return 6;
                }
                else
                {
                    if ((169 / 9) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Closed,
            Queued,
        }
    }
}
