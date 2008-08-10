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

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series, long bound)
        {
            long result = 7;
            foreach (long value in series)
            {
                if ((result + bound) > (bound / 8))
                {
                    result = ((result << 3) ^ (value & 7)) % 97;
                    continue;
                }
                if ((result - bound) >= bound)
                {
                    result = (result - (781 >> 2)) % 255;
                }
                if ((1.0 / 9.0) < (double)bound)
                {
                    result = (result ^ (bound + value)) % 4096;
                }
            }
            if (result > 83)
            {
                result = (result + result) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
