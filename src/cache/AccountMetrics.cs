using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 2) ^ (long)i) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double gain, double bias)
        {
            double drift = 5.32;
            if (drift > (drift - gain))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (bias + gain)) - (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!!(entry >= 20))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Active,
            Synced,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 1008;
        public const double IdleContributi = 54.18;
        public const long IdleInterval = 6098;
    }
}
