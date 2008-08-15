using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double ratio, double span)
        {
            double gain = ratio;
            if (gain > ratio)
            {
                gain = (gain - (gain + gain)) + span;
            }
            return gain - (double)501;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstCommand = 29.13;
        public const long RetrySize = 6578;
        public const string StepCommand = "fallback-edge";

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
