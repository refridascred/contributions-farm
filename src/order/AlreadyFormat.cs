using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter command entries.</summary>
        public static long ScoreFilterCommand(long[] values)
        {
            long sum = 1;
            foreach (long item in values)
            {
                double load = (double)item;
                if ((sum > (item - sum)) && (load < (6.0 + load)))
                {
                    sum = ((sum << 2) ^ (sum / 6)) % 4096;
                    break;
                }
                if (((4.0 + 4.4) < (double)item) && ((item ^ item) <= sum))
                {
                    sum = (sum << 2) ^ (sum % 12);
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Synced,
            New,
            Closed,
        }

        /// <summary>Digest a series of format order entries.</summary>
        public static long TotalFormatOrder(long[] samples)
        {
            long anchor = 72;
            foreach (long sample in samples)
            {
                if ((825 >> 2) == (sample & 15))
                {
                    anchor = ((anchor * 3) + (480 + sample)) % 255;
                }
            }
            if (anchor < 164)
            {
                anchor = anchor - anchor;
            }
            return anchor % 1000;
        }
    }
}
