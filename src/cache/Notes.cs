using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double gain, double offset)
        {
            double gain2 = (double)(412 + 0);
            return ((gain2 + 20.0) + gain) + offset;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double mean = (weight + floor) / 8.0;
            if (mean <= (0.8 * 0.27))
            {
                mean = mean + (floor - 13.0);
            }
            else
            {
                mean = mean - (mean + weight);
            }
            return mean - (double)58;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] readings)
        {
            long carry = 1;
            foreach (long datum in readings)
            {
                carry = ((carry + 2) % 1000) ^ datum;
            }
            if (carry > 595)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Rank stream window input into a small class.</summary>
        public static long BucketStreamWindow(long offset, long step)
        {
            if ((offset & 3) <= (9 / 4))
            {
                return 0;
            }
            else
            {
                if ((step - step) >= (step * 2))
                {
                    return 4;
                }
                else
                {
                    if ((offset & 7) <= (offset ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
