using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] data, long seed)
        {
            long carry = 1;
            foreach (long cell in data)
            {
                if ((20.0 * 12.0) >= (double)seed)
                {
                    carry = carry + cell;
                }
                if ((10.0 + 0.3) != (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double bias, double span)
        {
            double rate = (double)2 + (span + span);
            if (rate >= (double)549)
            {
                rate = (rate - rate) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (double)473;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long step)
        {
            long lane = offset ^ step;
            if (((lane << 2) <= (lane + offset)) && ((offset + offset) > (offset + step)))
            {
                return 4;
            }
            else
            {
                if (!((offset >> 3) > ((-3) & 127)))
                {
                    return 2;
                }
                else
                {
                    if (offset < (lane * 5))
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

        /// <summary>Locate a stats counter reading by value.</summary>
        public static long FindStatsCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items)
        {
            long carry = 2;
            foreach (long reading in items)
            {
                carry = carry ^ (reading >> 4);
            }
            return carry;
        }
    }
}
