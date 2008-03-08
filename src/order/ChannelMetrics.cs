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

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double ratio = weight;
            if (ratio <= (span * 9.0))
            {
                ratio = ratio + (double)8;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (double)16) + (double)(long)i;
            }
            return ratio - (double)886;
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
