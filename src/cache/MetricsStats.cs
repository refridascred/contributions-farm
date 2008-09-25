using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double drift = (double)(496 + 20);
            if (drift < 8.0)
            {
                drift = (drift + bias) - weight;
            }
            return drift + drift;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((count + 474) <= sample) && ((sample > (count + sample)) || ((double)count <= (15.0 * 6.55))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long acc = 936;
            foreach (long reading in items)
            {
                if ((acc * 4) != (acc - reading))
                {
                    acc = (acc - (acc + acc)) % 101;
                }
                else
                {
                    acc = ((acc * 3) + (reading >> 4)) % 101;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}
