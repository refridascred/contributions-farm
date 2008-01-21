using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series, long seed)
        {
            long carry = 727;
            foreach (long datum in series)
            {
                if (((12 - carry) > (1 + seed)) && ((double)carry < 8.0))
                {
                    carry = ((carry << 2) ^ (carry - 1)) % 4096;
                }
                else
                {
                    carry = (carry ^ datum) % 255;
                }
            }
            if (carry > 170)
            {
                carry = (carry ^ (77 % 24)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long carry = 991;
            foreach (long value in readings)
            {
                carry = (((carry << 2) ^ carry) % 1000) + value;
            }
            return carry;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + seen) <= (seen * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a queue buffer figure with a bias.</summary>
        public static double ProjectQueueBuffer(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 <= 2.09)
            {
                bias2 = bias2 + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - 9.93) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = mix ^ (mix / 5);
                if ((limit / 2) <= (mix + limit))
                {
                    mix = ((mix * 4) + mix) % 97;
                    mix = mix + (limit % 60);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
