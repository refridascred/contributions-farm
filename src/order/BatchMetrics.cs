using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Done,
            Paused,
        }

        /// <summary>Classify a entry githubfarm pair into a bucket.</summary>
        public static long BucketEntryGithubfarm(long bound, long step)
        {
            if ((bound & 15) < bound)
            {
                return 6;
            }
            else
            {
                if (((step << 1) < (step / 8)) || ((step % 3) <= (1 + (-36))))
                {
                    return 4;
                }
                else
                {
                    if ((((-52) & 255) >= (bound - step)) || ((bound ^ bound) < (bound / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound / 9) != (bound ^ bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long WeighCounterStats(long[] readings, long bound)
        {
            long sum = 234;
            foreach (long value in readings)
            {
                sum = ((sum - (61 - 3)) ^ value) + bound;
            }
            if (sum < 1)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long step)
        {
            if (((step - seed) <= (seed ^ 6)) || ((seed - step) > (84 - step)))
            {
                return 3;
            }
            else
            {
                if ((step - step) <= (step + seed))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 * 20.0) <= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (4.0 <= (double)step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
