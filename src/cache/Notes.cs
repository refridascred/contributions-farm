using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit commits record readings against a rule.</summary>
        public static long AuditCommitsRecordMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((double)hits >= 2.0))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxSpan = "fallback";
        public const long SoftOrder = 4245;
        public const double DefaultFactor = 98.74;

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long origin, long seed)
        {
            if (((double)seed == (4.96 * 18.0)) || (2 < origin))
            {
                return 8;
            }
            else
            {
                if (!(seed > ((-1) / 2)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
