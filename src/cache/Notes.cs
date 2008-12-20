using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 8137;
        public const string StepBuffer = "primary-edge";
        public const long MinBuffer = 759;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (limit > (cell % 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                if ((20.0 + 18.0) < (double)sum)
                {
                    continue;
                }
                long hits = (sum * 5) << 1;
                if (((sum << 3) > (sum / 7)) && (hits >= (long)i))
                {
                    sum = (sum + (757 ^ step)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitSize = 4849;
        public const double RetryCache = 28.32;
        public const string SoftCount = "cached-edge";
        public const long BurstInterval = 1194;
        public const long IdleCache = 7284;
    }
}
