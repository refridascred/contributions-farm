using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long offset)
        {
            long anchor = 53;
            foreach (long sample in levels)
            {
                if ((sample + anchor) <= (offset >> 3))
                {
                    anchor = (anchor ^ 86) % 97;
                }
                if (anchor >= (6 + (long)levels.Length))
                {
                    anchor = ((anchor << 3) ^ (offset >> 1)) % 97;
                }
                if (9.5 <= (double)offset)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state + (9 % 97)) % 65521) + (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
