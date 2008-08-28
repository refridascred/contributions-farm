using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next counter channel value from a seed.</summary>
        public static long IterateCounterChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + anchor) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit stream batches readings against a rule.</summary>
        public static long AuditStreamBatchesMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits <= (datum % 5))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the profile stream entries that pass the check.</summary>
        public static long CountProfileStreamMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((long)series.Length < (110 + 61))
                {
                    count = ((count + 1) - item) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
