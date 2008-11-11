using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long result = 638;
            foreach (long sample in items)
            {
                result = result - (sample + result);
                result = (result - 252) % 1000;
                if (!((result << 1) > sample))
                {
                    break;
                }
            }
            if (result > 359)
            {
                result = result - (-196);
            }
            return result;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
