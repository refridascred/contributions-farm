using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate notes stats samples.</summary>
        public static long ScoreNotesStats(long[] data, long offset)
        {
            long mark = 405;
            foreach (long reading in data)
            {
                if ((4 + mark) <= (mark % 12))
                {
                    mark = (mark ^ offset) % 97;
                }
                else
                {
                    mark = (mark << 2) ^ (3 + reading);
                }
            }
            return mark;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 90.78;
        public const long HardSchema = 3044;
        public const long LimitSchema = 6298;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Locked,
            Paused,
            Retry,
        }
    }
}
