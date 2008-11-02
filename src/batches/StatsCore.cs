using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRatio = 33.35;
        public const long RetrySpan = 9659;
        public const long MinRoute = 4451;
        public const string HardScore = "staging";
        public const long BaseDepth = 145;

        /// <summary>Measure how many already channel samples are out of range.</summary>
        public static long MeasureAlreadyChannelMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits % 7) > (hits ^ hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long bound, long seed)
        {
            if (seed > bound)
            {
                return 2;
            }
            else
            {
                if ((5.9 + 4.96) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            long gap = origin - offset;
            if ((gap % 3) > origin)
            {
                return 8;
            }
            else
            {
                if (((64 + origin) >= (gap / 9)) || ((offset & 127) != (gap + gap)))
                {
                    return 7;
                }
                else
                {
                    if ((origin + origin) <= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = result - step;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
