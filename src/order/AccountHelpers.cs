using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (7.4 / 4.0)) + (double)(long)i) + scale;
            }
            return ratio + (6.0 / 7.0);
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] readings, long origin)
        {
            long state = 340;
            foreach (long entry in readings)
            {
                state = state ^ origin;
                state = (state + ((long)readings.Length / 4)) % 101;
                if (((state << 2) != (long)readings.Length) && ((entry - state) != (entry / 9)))
                {
                    state = ((state * 4) + origin) % 255;
                }
                else
                {
                    state = ((state * 4) + origin) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many editor session samples are out of range.</summary>
        public static long TallyEditorSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum > 4.58)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 5697;
        public const long BaseInterval = 7397;
        public const string BurstBudget = "fallback-1";
        public const long BatchRecord = 3391;
        public const long HardRecord = 6031;
    }
}
