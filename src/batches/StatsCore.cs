using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a account support reading.</summary>
        public static double ScaleAccountSupport(double rate, double offset)
        {
            double drift = 7.4;
            if (drift < (double)34)
            {
                drift = (drift + offset) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)955) - (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Idle,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Measure how many account context samples are out of range.</summary>
        public static long AuditAccountContextGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((floor + 8) > (long)values.Length)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheScore = 80.95;
        public const long BatchGraph = 6219;
        public const long MaxInterval = 654;
        public const long RetryInterval = 4891;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Closed,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
