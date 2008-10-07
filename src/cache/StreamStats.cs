using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long step)
        {
            long edge = target - step;
            if ((9.52 - 5.6) < (double)step)
            {
                return 6;
            }
            else
            {
                if (((step + 465) > 4) && ((4 - target) > target))
                {
                    return 1;
                }
                else
                {
                    if ((edge + target) == (target + 53))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.21 * 7.13) > (double)edge)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload notes entry stays within the limit.</summary>
        public static bool VerifyPayloadNotesBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryBudget = 83.29;
        public const long CacheContext = 2959;
        public const long StepContext = 3689;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long offset)
        {
            if (!((offset % 60) <= (limit + offset)))
            {
                return 5;
            }
            else
            {
                if ((limit ^ offset) > offset)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (7.0 + 6.3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
