using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long total = 18;
            foreach (long reading in samples)
            {
                if (!((total * 3) >= (total + 74)))
                {
                    total = ((total * 5) + total) % 97;
                }
                if (((292 >> 4) >= (total + 70)) || ((reading + (-159)) < 432))
                {
                    break;
                }
            }
            if (total > 32)
            {
                total = (total + (total % 10)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of metrics layout readings.</summary>
        public static long WeighMetricsLayout(long[] readings)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                total = total - (9 / 5);
                total = total ^ (24 & 31);
                if ((cell / 4) > (total + cell))
                {
                    total = (total + ((long)readings.Length + 250)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc + (acc / 3)) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
