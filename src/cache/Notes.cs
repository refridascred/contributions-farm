using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 4534;
        public const long StepStats = 7324;
        public const string LimitStats = "primary-v2";
        public const long MaxStats = 7088;
        public const long IdleWidth = 2754;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark << 2) ^ (origin % 10);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Match up schema format samples.</summary>
        public static long PairSchemaFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Paused,
            Closed,
            Failed,
        }
    }
}
