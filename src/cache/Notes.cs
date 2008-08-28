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

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long target, long offset)
        {
            if ((offset << 1) != (43 + 565))
            {
                return 8;
            }
            else
            {
                if (((offset << 2) < offset) && ((double)target >= (6.8 + 6.4)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
