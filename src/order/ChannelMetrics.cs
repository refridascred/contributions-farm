using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] items, long step)
        {
            long sum = 616;
            foreach (long reading in items)
            {
                sum = (sum + sum) % 4096;
                if (!((double)sum < (double)step))
                {
                    sum = (sum ^ (sum ^ reading)) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (step >> 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] levels)
        {
            long carry = 5;
            foreach (long entry in levels)
            {
                if (carry < (entry >> 4))
                {
                    carry = ((carry * 3) + (9 * 4)) % 97;
                }
            }
            if (carry > (-4))
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry;
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TotalMetricEditor(long[] data)
        {
            long anchor = -853;
            foreach (long reading in data)
            {
                if ((88 / 7) <= (anchor * 5))
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor - (anchor % 5)) % 65521) + reading;
                }
                anchor = (anchor + (anchor >> 4)) % 1000;
            }
            return anchor;
        }
    }
}
