using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((double)count >= (double)datum) && ((count ^ datum) >= datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ ((long)i - anchor)) % 255;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
