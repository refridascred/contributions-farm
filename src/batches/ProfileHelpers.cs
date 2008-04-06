using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every channel record entry stays within the limit.</summary>
        public static bool ValidateChannelRecordBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                long prev = ((-48) + mix) >> 1;
                if (!((seed ^ mix) < seed))
                {
                    mix = ((mix * 2) + prev) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double scale, double span)
        {
            double bias = scale;
            if (bias > scale)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias - span;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (3.54 * 9.32)) - (double)(long)i;
            }
            return bias + (span / 9.0);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) >= cell)
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
