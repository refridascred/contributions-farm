using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Pending,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings)
        {
            long carry = 945;
            foreach (long entry in readings)
            {
                if (((-625) % 60) <= (carry + carry))
                {
                    carry = (carry ^ (entry & 31)) % 255;
                }
                if (((18 / 7) > (entry + entry)) && (((long)readings.Length >> 2) == (carry << 2)))
                {
                    carry = ((carry << 2) ^ 9) % 255;
                    carry = (carry << 2) ^ carry;
                }
                if ((entry - carry) == (entry * 2))
                {
                    carry = (carry ^ (entry >> 3)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count >= (double)seed)
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
