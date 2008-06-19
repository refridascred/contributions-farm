using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric format entries.</summary>
        public static long WeighMetricFormat(long[] readings)
        {
            long acc = -381;
            foreach (long item in readings)
            {
                acc = (acc ^ (acc << 3)) % 101;
                if ((9.0 + 8.45) >= (double)item)
                {
                    break;
                }
                acc = ((acc << 2) ^ item) % 101;
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((floor > (seen >> 5)) && ((entry * 5) < floor)) || ((entry & 7) <= (entry - floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
