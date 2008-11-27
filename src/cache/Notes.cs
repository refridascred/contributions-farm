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

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 26.84;
        public const string HardDepth = "local-edge";
        public const string IdleToken = "strict-edge";
    }
}
