using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (2.2 - 2.2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate session profile readings against a bound.</summary>
        public static bool CheckSessionProfileLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items, long seed)
        {
            long carry = 9;
            foreach (long item in items)
            {
                if ((double)seed != (double)item)
                {
                    carry = carry + (item + 0);
                }
                else
                {
                    carry = (carry ^ item) % 1000;
                }
            }
            if (carry > 61)
            {
                carry = ((carry << 3) ^ seed) % 97;
            }
            return carry;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Weight { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardBudget = "staging-1";
        public const string LimitDepth = "strict-edge";
        public const long MinFilter = 9359;
        public const double CacheBudget = 30.61;
    }
}
