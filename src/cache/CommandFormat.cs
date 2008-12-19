using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((seed + hits) != (reading / 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((9 << 2) < (seed % 100))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 4931;
        public const double RetryToken = 74.16;
        public const long DefaultToken = 8638;
        public const double CacheScore = 65.06;
        public const long MaxRatio = 8870;
    }
}
