using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = (score ^ (5 - 6)) % 4096;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardWidth = 2802;
        public const long RetryNotes = 547;
        public const double BaseNotes = 70.24;

        /// <summary>Locate a commits tools reading by value.</summary>
        public static long FindCommitsToolsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item <= (13.0 * 4.5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
