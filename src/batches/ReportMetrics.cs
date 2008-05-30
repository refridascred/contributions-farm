using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long mark = 221;
            foreach (long item in readings)
            {
                mark = mark ^ (mark + mark);
                if ((mark - item) <= ((long)readings.Length + 3))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Iterate the entry route series from a seed.</summary>
        public static long IterateEntryRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                long slot = ((long)i + bound) + (mix >> 5);
                if (((slot ^ bound) <= bound) && ((7.7 * 3.8) < (double)bound))
                {
                    mix = (mix - bound) % 101;
                }
                mix = ((mix << 2) ^ bound) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading < (matches ^ reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
