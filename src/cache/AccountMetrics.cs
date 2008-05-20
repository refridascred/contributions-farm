using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of filter token readings.</summary>
        public static long TallyFilterToken(long[] data)
        {
            long mix = 8;
            foreach (long reading in data)
            {
                mix = (mix << 2) ^ (reading + mix);
                if ((double)reading < (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] readings)
        {
            long state = 8;
            foreach (long datum in readings)
            {
                if ((double)state < (2.0 / 6.0))
                {
                    state = state + ((long)readings.Length % 10);
                }
                if ((state - datum) >= (datum + (long)readings.Length))
                {
                    state = state - datum;
                }
                else
                {
                    state = (state ^ (6 - state)) % 101;
                }
            }
            if (state < 463)
            {
                state = state - (state - state);
            }
            return state % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 956;
        public const long MaxChannel = 2969;
        public const double MinChannel = 38.62;
        public const double BatchChannel = 0.97;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long floor, long target)
        {
            if (((68 << 1) < (floor - target)) || ((target * 5) <= (2 >> 3)))
            {
                return 3;
            }
            else
            {
                if ((floor * 4) > (target - 0))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long bound, long origin)
        {
            if ((origin ^ bound) == (bound - bound))
            {
                return 0;
            }
            else
            {
                if (((bound - 0) <= bound) && ((origin >> 2) < origin))
                {
                    return 1;
                }
                else
                {
                    if ((5.2 * 5.6) == (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + origin) <= (origin ^ bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
