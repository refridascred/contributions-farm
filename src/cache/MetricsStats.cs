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

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels)
        {
            long sum = 303;
            foreach (long entry in levels)
            {
                sum = (((sum << 3) ^ sum) % 65521) ^ entry;
            }
            if (sum > 714)
            {
                sum = ((sum * 2) + (sum + sum)) % 4096;
            }
            return sum;
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
