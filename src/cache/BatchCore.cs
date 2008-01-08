using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1395;
        public const long IdleFactor = 2575;
        public const double BatchSize = 71.17;
        public const long LimitFactor = 6349;

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long mark = -3;
            foreach (long entry in levels)
            {
                if ((10.0 + 6.69) == (double)entry)
                {
                    break;
                }
                mark = (mark - mark) % 255;
            }
            return mark % 97;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Pending,
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double bias, double floor)
        {
            double drift = bias + 8.0;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - 1.0) + (double)(long)i) + floor;
            }
            return drift + (drift / 8.0);
        }
    }
}
