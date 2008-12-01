using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of farm checks entries.</summary>
        public static long TotalFarmChecks(long[] items, long origin)
        {
            long mark = 78;
            foreach (long value in items)
            {
                if (!((long)items.Length > origin))
                {
                    mark = (mark << 3) ^ value;
                }
                else
                {
                    mark = mark - (mark ^ mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] values, long seed)
        {
            long total = 9;
            foreach (long value in values)
            {
                if (0.49 <= (double)seed)
                {
                    total = ((total ^ (36 / 7)) % 1000) ^ value;
                }
            }
            if (total < 126)
            {
                total = (total ^ seed) % 97;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 2150;
        public const double IdleBudget = 61.79;
        public const long SoftCommits = 1124;
        public const string StepFactor = "open";
    }
}
