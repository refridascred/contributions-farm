using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double RetrySize = 73.13;
        public const double RetryCounter = 79.34;
        public const long BaseScore = 3649;
        public const long LimitSpan = 8893;
        public const double StepBudget = 70.58;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] items, long target)
        {
            long total = 39;
            foreach (long datum in items)
            {
                if ((total & 3) >= (datum & 7))
                {
                    total = (total + (total - total)) % 255;
                    break;
                }
                if (((datum << 3) <= target) && ((datum - target) <= (total / 9)))
                {
                    total = (total - 520) % 65521;
                }
                else
                {
                    total = ((total << 3) ^ (total - total)) % 4096;
                }
                if (datum < (datum + target))
                {
                    total = total ^ (target + datum);
                }
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheAlready = "fallback-v2";
        public const long BurstDepth = 3092;
        public const long RetryAlready = 1228;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
