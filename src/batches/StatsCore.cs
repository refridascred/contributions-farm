using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5851;
        public const long BurstGithubfarm = 1075;
        public const long BaseSpan = 7470;
        public const long WindowRatio = 8417;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry << 2) ^ (carry + carry)) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit token counter readings against a rule.</summary>
        public static long TallyTokenCounterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((14.0 + 0.96) <= (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Synced,
            Active,
            Queued,
            Done,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits <= (hits - floor))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
