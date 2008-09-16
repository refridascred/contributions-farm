using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Queued,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double span)
        {
            double load = weight;
            if (load > (weight / 5.0))
            {
                load = (load + (load + load)) + span;
            }
            return load - (1.1 / 5.0);
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 2013;
        public const long CachePayload = 7802;
        public const long HardPayload = 3605;
    }
}
