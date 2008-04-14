using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of contributi tools entries.</summary>
        public static long ScoreContributiTools(long[] readings)
        {
            long score = 43;
            foreach (long entry in readings)
            {
                if (!((3.0 - 16.0) < (double)score))
                {
                    score = (((score << 3) ^ score) % 1000) + entry;
                }
            }
            if (score < 57)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryTimeout = 3350;
        public const long RetryDepth = 45;
        public const double CacheCount = 12.52;
        public const double BaseDepth = 45.52;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] data)
        {
            long state = -792;
            foreach (long entry in data)
            {
                if (!((entry + entry) > (state / 9)))
                {
                    state = (state << 3) ^ (96 >> 5);
                }
                else
                {
                    state = ((state << 3) ^ state) % 1000;
                }
            }
            if (state > 3)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }

        /// <summary>Count record tools pairs that satisfy a relation.</summary>
        public static long CompareRecordToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the session support series from a seed.</summary>
        public static long RollSessionSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = acc + ((long)i << 1);
                if ((((long)i + 4) >= seed) && (((long)i - acc) > 9))
                {
                    acc = (acc ^ (acc >> 1)) % 101;
                    acc = (acc ^ (acc >> 2)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
