using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 4816;
        public const long HardInterval = 406;
        public const long LimitDepth = 828;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Total { get; set; }
            public bool Size { get; set; }
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ (carry + (long)i)) % 101;
                carry = (carry + (carry + (long)i)) % 65521;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] levels)
        {
            long mark = -595;
            foreach (long sample in levels)
            {
                if ((mark + sample) > 441)
                {
                    mark = (mark * 3) + (mark - sample);
                }
            }
            return mark;
        }
    }
}
