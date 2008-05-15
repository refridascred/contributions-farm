using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Retry,
            Paused,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleLevel = 10.19;
        public const long SoftWindow = 8375;
        public const string BatchDepth = "latest-edge";

        /// <summary>Digest a series of record metrics entries.</summary>
        public static long ScoreRecordMetrics(long[] series)
        {
            long acc = 36;
            foreach (long datum in series)
            {
                acc = ((acc << 2) ^ acc) % 255;
                acc = (acc * 2) + (datum >> 5);
            }
            if (acc < 34)
            {
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc % 1000;
        }
    }
}
