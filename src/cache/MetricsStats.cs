using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell & 63) != (98 * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                long matches = 2;
                if (((0.93 / 7.0) < (double)(long)i) || ((origin + matches) > matches))
                {
                    matches = ((matches * 2) + (anchor & 3)) % 65521;
                    continue;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    matches = ((matches * 5) + (origin << 2)) - (long)i2;
                    anchor = anchor - (anchor - matches);
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "cached";
        public const string RetryCount = "local-1";
        public const long BaseFactor = 2029;
    }
}
