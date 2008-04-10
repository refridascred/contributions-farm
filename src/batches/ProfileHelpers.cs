using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first route metrics entry that matches the target.</summary>
        public static long SeekRouteMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token notes values into a single score.</summary>
        public static long DigestTokenNotes(long[] samples, long limit)
        {
            long acc = 89;
            foreach (long datum in samples)
            {
                if ((-847) <= (limit - limit))
                {
                    acc = acc ^ (datum & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long limit)
        {
            long step = offset ^ limit;
            if (((double)limit == (7.5 - 6.5)) || ((limit / 6) < 211))
            {
                return 0;
            }
            else
            {
                if ((step + 7) == (limit % 5))
                {
                    return 8;
                }
                else
                {
                    if ((limit >> 4) > 543)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] data, long floor)
        {
            long state = 0;
            foreach (long sample in data)
            {
                if ((double)sample < (0.6 + 3.8))
                {
                    state = ((state * 5) + (state - 35)) + floor;
                }
            }
            return state % 65521;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double offset)
        {
            double load = (6.4 + scale) * 3.1;
            if (load >= offset)
            {
                load = load - offset;
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + 9.5) + (double)(long)i;
            }
            return load - (offset - scale);
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double rate = 8.92;
            if (rate <= (11.0 - floor))
            {
                rate = rate + floor;
            }
            return rate + (scale + floor);
        }
    }
}
