using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((74 & 31) != (matches + 860))
                {
                    matches = ((matches + 2) + value) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinInterval = 2160;
        public const long IdleFactor = 2809;
        public const long DefaultDepth = 7452;
        public const long CacheBatch = 8076;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long sum = 1;
            foreach (long reading in readings)
            {
                if ((sum + reading) < (sum - sum))
                {
                    sum = sum ^ sum;
                }
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
