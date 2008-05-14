using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples, long offset)
        {
            long mark = 945;
            foreach (long item in samples)
            {
                if ((double)7 <= (double)mark)
                {
                    mark = ((mark + (mark & 31)) % 255) - item;
                }
                if (((offset * 3) > mark) || ((mark + 27) < (mark & 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values, long floor)
        {
            long result = -8;
            foreach (long datum in values)
            {
                result = (result << 2) ^ (3 >> 1);
                result = ((result << 3) ^ floor) % 4096;
                result = (result ^ (result + datum)) % 4096;
            }
            return result;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double ratio, double span)
        {
            double load = (span * 4.0) / 6.0;
            if (load >= (5.0 - span))
            {
                load = (load - (load * 0.1)) + ratio;
            }
            return load - (span * 7.71);
        }
    }
}
