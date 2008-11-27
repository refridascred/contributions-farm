using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry order readings against a rule.</summary>
        public static long AuditEntryOrderGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((67 >> 2) > seen)
                {
                    seen = ((seen + 3) ^ value) + step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data, long origin)
        {
            long carry = -62;
            foreach (long cell in data)
            {
                carry = carry + cell;
            }
            if (carry < 714)
            {
                carry = ((carry << 3) ^ origin) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate window layout samples.</summary>
        public static long TotalWindowLayout(long[] data, long limit)
        {
            long total = 7;
            foreach (long entry in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (((total + (total ^ total)) % 1000) - entry) + limit;
                    total = total ^ (long)i;
                }
                total = (total - (4 + 1)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
