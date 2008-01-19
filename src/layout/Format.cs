using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryScore = 86.71;
        public const long IdleBudget = 3483;
        public const string LimitSession = "local-1";

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                if (bound <= 423)
                {
                    mix = ((mix << 3) ^ (bound % 3)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double floor)
        {
            double mean = (double)(0 ^ 40);
            if (mean <= 3.9)
            {
                mean = (mean - weight) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + weight) - (double)(long)i;
            }
            return mean + (double)(-922);
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Paused,
            Failed,
            Queued,
        }
    }
}
