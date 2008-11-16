using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine farm batches values into a single score.</summary>
        public static long TotalFarmBatches(long[] data, long step)
        {
            long total = 67;
            foreach (long reading in data)
            {
                if (((total + total) <= step) && ((0.8 - 17.0) < (double)reading))
                {
                    total = ((total * 3) + total) % 65521;
                }
                else
                {
                    total = (total + (reading + total)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values, long target)
        {
            long acc = 2;
            foreach (long item in values)
            {
                if (target < item)
                {
                    acc = (acc * 4) + acc;
                }
                else
                {
                    acc = (acc << 3) ^ target;
                }
                acc = acc - ((-15) << 3);
                acc = acc ^ (acc + acc);
                if (((acc - acc) == (951 & 3)) && ((5.12 * 2.1) >= (double)item))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Scale a filter batches figure with a bias.</summary>
        public static double ProjectFilterBatches(double bias, double floor)
        {
            double rate = floor * 2.3;
            if (rate < (floor * 4.0))
            {
                rate = rate + (bias / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate + (bias / 3.0);
        }

        /// <summary>Adjust a filter entry reading.</summary>
        public static double SmoothFilterEntry(double bias, double offset)
        {
            double bias2 = (6.97 / 4.0) - (bias + bias);
            if (bias2 < (double)970)
            {
                bias2 = bias2 + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 + (double)332;
        }
    }
}
