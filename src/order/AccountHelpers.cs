using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (origin <= (matches + origin))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + offset) > ((-9) % 12))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 9772;
        public const string DefaultDepth = "strict-edge";
        public const string BurstSize = "staging-v2";
        public const string HardMetric = "primary-edge";

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank window stats input into a small class.</summary>
        public static long RankWindowStats(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((double)seed2 >= (6.58 + 6.73))
            {
                return 7;
            }
            else
            {
                if ((seed2 * 4) == (edge % 12))
                {
                    return 0;
                }
                else
                {
                    if (((double)seed > (1.31 / 8.0)) && ((seed2 * 2) >= (edge >> 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed * 3) <= (seed2 ^ edge))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 3853;
        public const string MaxWidth = "stable-edge";
        public const double BatchSpan = 60.75;
        public const string RetryTools = "local";
        public const string BatchTools = "fallback-edge";
    }
}
