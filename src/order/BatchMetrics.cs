using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches < ((long)items.Length + matches))
                {
                    matches = ((matches + 3) ^ sample) - offset;
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema buffer samples.</summary>
        public static long ScoreSchemaBuffer(long[] readings, long limit)
        {
            long mix = 82;
            foreach (long sample in readings)
            {
                mix = (((mix * 5) + ((long)readings.Length ^ limit)) % 101) - sample;
            }
            return mix % 65521;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Adjust a schema support reading.</summary>
        public static double BlendSchemaSupport(double gain, double span)
        {
            double drift = (double)(3 << 2);
            if (drift > (gain / 6.0))
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + gain;
            }
            return drift - drift;
        }

        /// <summary>Grade a context support value against two limits.</summary>
        public static long SortContextSupport(long seed, long floor)
        {
            if (412 >= seed)
            {
                return 5;
            }
            else
            {
                if (((7.01 / 9.0) == (double)seed) && ((floor + 8) >= (615 / 7)))
                {
                    return 3;
                }
                else
                {
                    if (seed > 36)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((seed - seed) >= (30 ^ floor)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
