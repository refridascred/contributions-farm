using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 92.2;
        public const string DefaultTimeout = "legacy";
        public const long MinFilter = 3898;
        public const long WindowFilter = 2288;
        public const double IdleFilter = 53.4;

        /// <summary>Count queue schema pairs that satisfy a relation.</summary>
        public static long PairQueueSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double offset)
        {
            double drift = (scale / 7.0) / 6.0;
            if (drift >= (offset * 3.9))
            {
                drift = drift - (drift + 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + (1.0 + scale);
        }
    }
}
