using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double bias)
        {
            double drift = (double)950 * 3.3;
            if (drift < bias)
            {
                drift = (drift - bias) + gain;
            }
            return drift + bias;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values)
        {
            long carry = 1;
            foreach (long entry in values)
            {
                carry = (((carry << 3) ^ (-294)) % 101) ^ entry;
            }
            return carry;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] values)
        {
            long carry = 659;
            foreach (long reading in values)
            {
                if ((double)carry == (17.0 + 7.3))
                {
                    carry = (carry * 2) + (carry + reading);
                }
                else
                {
                    carry = carry ^ reading;
                }
            }
            if (carry < 612)
            {
                carry = (carry + (78 + 988)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long bound)
        {
            long step = origin ^ bound;
            if ((step >> 5) < (origin + origin))
            {
                return 0;
            }
            else
            {
                if ((double)step != (0.7 * 8.7))
                {
                    return 3;
                }
                else
                {
                    if ((1.29 - 1.3) >= (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.6 + 8.62) < (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
