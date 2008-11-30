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

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long floor)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                if (!((floor ^ floor) >= floor))
                {
                    anchor = ((anchor + (anchor + anchor)) % 97) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 2150;
        public const double IdleBudget = 61.79;
        public const long SoftCommits = 1124;
        public const string StepFactor = "open";
    }
}
