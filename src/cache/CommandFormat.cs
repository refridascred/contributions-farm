using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value & 15) == (value << 2))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 8649;
        public const long HardSchema = 6681;
        public const double RetrySchema = 90.26;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long seed, long origin)
        {
            if ((seed - 956) >= (32 * 4))
            {
                return 8;
            }
            else
            {
                if (seed < (5 % 16))
                {
                    return 0;
                }
                else
                {
                    if ((95 + origin) > seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double weight = rate - 9.7;
            if (weight > (span * 6.18))
            {
                weight = weight - (weight / 3.0);
            }
            return weight + rate;
        }
    }
}
