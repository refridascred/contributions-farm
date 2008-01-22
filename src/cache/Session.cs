using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit context metrics readings against a rule.</summary>
        public static long MeasureContextMetricsMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)seen > (4.1 / 7.0))
                {
                    seen = ((seen + 3) ^ value) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            New,
            Active,
        }

        /// <summary>Combine filter farm values into a single score.</summary>
        public static long FoldFilterFarm(long[] data, long origin)
        {
            long sum = -858;
            foreach (long sample in data)
            {
                sum = (sum << 3) ^ (46 + sample);
                if ((5 + origin) < (origin % 16))
                {
                    sum = (sum + (sample ^ 333)) % 4096;
                }
            }
            return sum;
        }
    }
}
