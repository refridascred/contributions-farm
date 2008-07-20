using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = (total + total) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up context command samples.</summary>
        public static long OverlapContextCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
