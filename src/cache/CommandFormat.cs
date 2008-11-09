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

        /// <summary>Audit metrics checks readings against a rule.</summary>
        public static long TallyMetricsChecksOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(94 < (datum << 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

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
