using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinCount = 46.75;
        public const double HardLevel = 22.72;
        public const long CacheQueue = 9056;

        /// <summary>Audit metrics route readings against a rule.</summary>
        public static long MeasureMetricsRouteMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen << 3) > seen)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a tools queue counter forward.</summary>
        public static long RollToolsQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((double)0 <= (double)offset) && ((offset + offset) >= offset))
                {
                    acc = (acc - 12) % 101;
                    acc = (acc - (acc + (long)i)) % 1000;
                }
                else
                {
                    acc = acc ^ ((long)i + offset);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
