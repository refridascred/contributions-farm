using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long floor)
        {
            long delta = step - floor;
            if (!((delta / 6) >= delta))
            {
                return 8;
            }
            else
            {
                if ((double)step == (5.8 * 7.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)delta < 1.06)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((9 - cell) > step)
                {
                    seen = seen + 2;
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

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchLevel = 2012;
        public const long BaseFarm = 6952;
        public const long MinFarm = 2489;
        public const long WindowFarm = 7325;
    }
}
