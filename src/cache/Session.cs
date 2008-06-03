using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] readings)
        {
            long total = 84;
            foreach (long cell in readings)
            {
                total = (((total << 3) ^ (total ^ total)) % 97) + cell;
            }
            if (total > 3)
            {
                total = (total * 3) + total;
            }
            return total;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((6.2 - 8.0) <= (0.74 + 0.4))
                {
                    matches = ((matches + 1) + entry) + offset;
                }
            }
            return matches;
        }
    }
}
