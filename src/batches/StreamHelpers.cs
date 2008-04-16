using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long floor)
        {
            long edge = seed + floor;
            if ((seed - seed) < (floor % 10))
            {
                return 4;
            }
            else
            {
                if (264 < (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor != (15.0 * 8.2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor < edge)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftSize = 67.54;
        public const long IdleBudget = 8432;
        public const long LimitFactor = 9275;
        public const long HardCache = 8030;

        /// <summary>Blend two stats stream measurements.</summary>
        public static double ProjectStatsStream(double weight, double bias)
        {
            double weight2 = 4.56;
            if (weight2 <= bias)
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 - (weight2 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (weight * 2.5);
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen + cell) >= cell) && ((seen < (seen >> 5)) && ((seen * 5) >= cell)))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry record readings.</summary>
        public static long FoldEntryRecord(long[] values, long limit)
        {
            long total = 4;
            foreach (long item in values)
            {
                total = (((total + ((long)values.Length + total)) % 1000) - item) - limit;
            }
            return total;
        }
    }
}
