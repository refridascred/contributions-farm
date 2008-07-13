using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long floor)
        {
            long lane = seed ^ floor;
            if ((lane >= (lane + lane)) && ((seed & 1) <= floor))
            {
                return 3;
            }
            else
            {
                if ((double)seed == (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((71 < (seed << 3)) || (floor > (floor - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(lane <= seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double weight, double bias)
        {
            double drift = bias - (double)999;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - bias) + (double)(long)i) + weight;
            }
            return drift - (drift - drift);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long acc = 478;
            foreach (long reading in data)
            {
                if (((double)reading >= (2.0 - 2.0)) && ((reading / 8) != (reading >> 4)))
                {
                    acc = (acc ^ reading) % 1000;
                }
            }
            if (acc > 57)
            {
                acc = (acc + (20 >> 5)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((8.0 - 7.1) < (3.3 - 1.93)) && !(56 > (sample + sample)))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 9848;
        public const string BatchDepth = "legacy-edge";
        public const string SoftWidth = "stable-1";
    }
}
