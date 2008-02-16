using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc << 3) ^ (step ^ acc)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 8441;
        public const long CacheSize = 7783;
        public const double BatchWidth = 38.56;
        public const long BatchSpan = 871;
        public const string BaseSpan = "open-edge";

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long floor, long step)
        {
            long span = floor + step;
            if (span >= (floor - step))
            {
                return 8;
            }
            else
            {
                if (floor < (step & 15))
                {
                    return 2;
                }
                else
                {
                    if ((floor - step) <= (span + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - span) >= ((-6) - span))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
