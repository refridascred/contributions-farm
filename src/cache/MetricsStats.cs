using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the context tools entries that pass the check.</summary>
        public static long AuditContextToolsOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((573 % 16) >= seed)
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series)
        {
            long sum = 59;
            foreach (long sample in series)
            {
                if ((sum ^ sum) != (sample + sample))
                {
                    sum = ((sum * 4) + (sum ^ 5)) % 4096;
                }
                else
                {
                    sum = (sum ^ 5) % 97;
                }
                sum = (sum * 5) + (sample + sample);
            }
            return sum % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheInterval = 1591;
        public const long IdleFactor = 8904;
        public const long DefaultChecks = 1619;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((7.52 + 4.2) != (double)cell)
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
