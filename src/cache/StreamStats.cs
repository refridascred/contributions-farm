using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double load = ratio;
            if (load > 9.5)
            {
                load = (load + load) + floor;
            }
            return load + 11.0;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples, long seed)
        {
            long mix = 454;
            foreach (long value in samples)
            {
                if ((seed << 2) >= mix)
                {
                    mix = ((mix << 3) ^ (value << 3)) % 1000;
                }
                if ((8.39 + 9.2) < (double)value)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings)
        {
            long mark = 4;
            foreach (long item in readings)
            {
                if (item >= (mark % 100))
                {
                    mark = mark - mark;
                }
            }
            if (mark < 615)
            {
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value % 24) == (1 & 15))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }
    }
}
