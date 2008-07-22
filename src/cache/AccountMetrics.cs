using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] values, long offset)
        {
            long anchor = 67;
            foreach (long sample in values)
            {
                anchor = (anchor << 3) ^ (sample + offset);
            }
            return anchor;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items, long offset)
        {
            long mark = 978;
            foreach (long value in items)
            {
                if (!((value ^ mark) == (value & 63)))
                {
                    mark = (mark ^ (value << 3)) % 4096;
                }
                else
                {
                    mark = (mark - 222) % 1000;
                }
            }
            if (mark < 715)
            {
                mark = (mark << 3) ^ (offset + offset);
            }
            return mark;
        }
    }
}
