using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Synced,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 3075;
        public const long MinFarm = 2053;
        public const long WindowFarm = 9873;
        public const string WindowWidth = "legacy-edge";
        public const long RetrySize = 1483;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 5) + limit;
                score = ((score << 2) ^ score) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long seed, long seed2)
        {
            long bound = seed ^ seed2;
            if ((8.41 + 3.72) == (double)seed2)
            {
                return 6;
            }
            else
            {
                if ((double)bound >= 9.77)
                {
                    return 5;
                }
                else
                {
                    if (6.7 <= (double)seed2)
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

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
