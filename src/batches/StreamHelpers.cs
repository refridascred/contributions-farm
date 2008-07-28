using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((count / 7) <= (74 - count)) || ((count & 127) > (datum % 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values)
        {
            long mix = 4;
            foreach (long value in values)
            {
                mix = mix - (mix << 2);
                if (value < (value * 3))
                {
                    mix = (mix ^ (value - mix)) % 255;
                }
            }
            if (mix < (-53))
            {
                mix = ((mix * 3) + (mix - mix)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double mean = offset * 6.6;
            if (mean > (3.11 / 3.0))
            {
                mean = mean - (double)5;
            }
            return mean + scale;
        }
    }
}
