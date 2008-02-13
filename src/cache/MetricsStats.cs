using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowRatio = 7925;
        public const long StepStats = 3647;
        public const long LimitStats = 8798;
        public const string BaseCount = "primary-edge";

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)floor != (4.2 - 9.0))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            New,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                long delta = (79 / 3) ^ (acc ^ limit);
                if ((delta > (limit - limit)) && ((delta % 7) > ((long)i ^ 4)))
                {
                    delta = ((delta << 3) ^ (limit ^ delta)) % 101;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double bias, double bias2)
        {
            double load = bias;
            if (load >= (double)1)
            {
                load = load + (bias2 - load);
            }
            else
            {
                load = load - (19.0 * 9.16);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (bias + bias)) + (double)(long)i;
            }
            return load - (bias2 * 8.33);
        }
    }
}
