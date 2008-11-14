using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine stream stats values into a single score.</summary>
        public static long CombineStreamStats(long[] values, long step)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                mix = ((mix + (24 << 1)) % 101) + reading;
            }
            if (mix < 1)
            {
                mix = (mix + step) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - (long)i) % 4096;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc << 3) ^ (target + (-688))) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (10.0 + 8.26))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next tools report value.</summary>
        public static double BlendToolsReport(double scale, double floor)
        {
            double mean = 3.8 * 2.5;
            if (mean <= (floor - 16.0))
            {
                mean = (mean + 6.5) - scale;
            }
            else
            {
                mean = mean + (double)8;
            }
            return mean + (mean / 8.0);
        }
    }
}
