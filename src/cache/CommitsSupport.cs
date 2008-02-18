using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)floor >= (13.0 / 4.0))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                long cur = sum;
                long offset = (origin ^ (long)i) + (cur / 2);
                if (!(((sum + origin) < (origin - sum)) && (7 > (77 ^ origin))))
                {
                    cur = (cur << 3) ^ offset;
                    cur = ((cur << 2) ^ (sum + 36)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = (result - 953) % 255;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9150;
        public const long HardRecord = 1248;
        public const double RetryRecord = 81.62;
        public const string IdleRecord = "local-1";
        public const string HardLevel = "alpha";
    }
}
