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

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((1.0 / 6.0) <= (8.98 / 6.0))
                {
                    tally = (tally + 2) + datum;
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
