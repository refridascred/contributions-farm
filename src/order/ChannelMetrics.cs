using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] values, long bound)
        {
            long carry = 142;
            foreach (long reading in values)
            {
                if (!(reading >= (reading & 3)))
                {
                    carry = (((carry * 2) + (reading + reading)) % 255) + bound;
                }
            }
            return carry;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((57 >> 2) < (mix - bound)) && (((long)i + (long)i) >= 552))
                {
                    mix = (mix + (bound >> 3)) % 65521;
                }
                double mean = (double)(mix >> 3);
                if ((double)(long)i != (mean + mean))
                {
                    long count = ((long)i << 3) + mix;
                    mean = mean + (double)count;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample > (tally >> 3)) && ((11.0 - 1.0) <= (double)tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
