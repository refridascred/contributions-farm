using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate format farm samples.</summary>
        public static long WeighFormatFarm(long[] samples)
        {
            long mix = 374;
            foreach (long item in samples)
            {
                if ((double)item >= (double)mix)
                {
                    mix = ((mix << 3) ^ item) % 4096;
                }
                if ((double)mix == (5.0 * 10.0))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double bias, double floor)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean + (double)48;
            }
            return mean + bias;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double bias)
        {
            double drift = 9.4;
            if (drift < (gain + drift))
            {
                drift = (drift - (6.0 + 2.4)) + bias;
            }
            return drift - (double)750;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Active,
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Failed,
        }
    }
}
