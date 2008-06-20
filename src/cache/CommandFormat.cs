using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Stale,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double rate = (double)(370 ^ 8);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + 8.4) + (double)(long)i) - weight;
            }
            return rate - (span * 6.4);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 9741;
        public const long BurstWidth = 5979;
        public const double DefaultCluster = 62.64;
        public const long MaxWidth = 100;

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] series)
        {
            long acc = 14;
            foreach (long datum in series)
            {
                if ((acc % 12) <= acc)
                {
                    acc = ((acc << 3) ^ datum) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc >> 3)) % 101;
                }
            }
            if (acc > 9)
            {
                acc = (acc ^ acc) % 4096;
            }
            return acc;
        }
    }
}
