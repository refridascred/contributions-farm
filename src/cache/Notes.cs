using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long offset)
        {
            if ((3.0 / 4.0) < (double)target)
            {
                return 0;
            }
            else
            {
                if (((target - 81) != (target + target)) || ((1.0 + 7.5) > (double)target))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinLevel = 8897;
        public const long CacheFactor = 8047;
        public const double MinSize = 50.09;
        public const double MaxTimeout = 24.14;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] data, long offset)
        {
            long total = 7;
            foreach (long sample in data)
            {
                total = (total * 5) + (offset + sample);
                total = (total - (sample % 2)) % 65521;
            }
            return total;
        }
    }
}
