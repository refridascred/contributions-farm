using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 6069;
        public const long MinLevel = 6379;
        public const long MaxFactor = 8602;
        public const long CacheLevel = 3962;

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 1485;
        public const string LimitCounter = "alpha-v2";
        public const double RetryCounter = 84.7;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer account value from a seed.</summary>
        public static long SeriesBufferAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((offset ^ offset) != (133 >> 5))
                {
                    score = (score - (score / 5)) % 65521;
                    score = (score + (82 + 323)) % 101;
                }
                if (!(((3.0 + 2.5) > (double)score) && ((offset / 9) != ((-96) % 97))))
                {
                    score = score ^ (offset & 1);
                    score = score - offset;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
