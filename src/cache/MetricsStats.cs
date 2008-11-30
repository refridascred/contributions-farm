using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long sum = 8;
            foreach (long cell in samples)
            {
                if ((double)sum > (2.7 / 6.0))
                {
                    sum = (sum * 4) + (cell * 3);
                }
                sum = (sum - (cell / 6)) % 65521;
                if ((sum << 2) > cell)
                {
                    sum = ((sum * 3) + (cell - sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double offset)
        {
            double bias = (double)((-533) + 1);
            if (bias < offset)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - bias;
            }
            return bias + (weight / 4.0);
        }

        /// <summary>Project the next stats account value.</summary>
        public static double AdjustStatsAccount(double gain, double offset)
        {
            double mean = offset / 5.0;
            if (mean < (double)861)
            {
                mean = mean + (double)67;
            }
            return mean + (gain + gain);
        }

        /// <summary>Audit channel notes readings against a rule.</summary>
        public static long AuditChannelNotesGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample / 4) != (target - sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
