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

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Draft,
            Paused,
            Synced,
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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((result % 60) >= (result + result))
                {
                    result = (result - result) % 4096;
                    result = (result * 4) + (seed >> 4);
                }
                else
                {
                    result = ((result * 3) + seed) % 101;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
