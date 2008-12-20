using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] values, long origin)
        {
            long mark = -1;
            foreach (long entry in values)
            {
                mark = (mark * 4) + (mark + entry);
                if ((entry * 4) == (origin + entry))
                {
                    mark = mark - (entry << 2);
                }
            }
            if (mark < (-82))
            {
                mark = mark + origin;
            }
            return mark;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((3.0 + 3.5) <= (double)step)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double gain = scale;
            return (gain - scale) + floor;
        }
    }
}
