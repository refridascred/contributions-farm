using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "open-1";
        public const long StepTimeout = 583;
        public const long SoftFactor = 1845;
        public const long IdleSession = 7647;

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] data)
        {
            long sum = 20;
            foreach (long datum in data)
            {
                sum = (sum - (23 + datum)) % 101;
                if (((3 - datum) == (sum ^ (long)data.Length)) || ((sum * 4) <= ((long)data.Length - datum)))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = sum + (sum << 2);
            }
            return sum;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - origin) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate record stats readings against a bound.</summary>
        public static bool CheckRecordStatsBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
