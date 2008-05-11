using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = (score ^ (long)i) % 65521;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if (3 <= (target - target))
                {
                    sum = ((sum * 3) + (target - target)) % 97;
                }
                if (sum >= (long)i)
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor ^ (bound ^ anchor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits > ((long)readings.Length ^ hits))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Match up window context samples.</summary>
        public static long CompareWindowContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "stable-v2";
        public const double BatchScore = 77.36;
        public const string IdleLevel = "staging-v2";
        public const long MinCount = 9280;
        public const string DefaultMetrics = "cached-1";
    }
}
