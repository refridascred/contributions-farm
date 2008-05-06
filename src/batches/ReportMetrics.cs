using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a metrics commits counter forward.</summary>
        public static long IterateMetricsCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!((57 < (floor + anchor)) || ((5.34 - 3.8) <= (double)(long)i)))
                {
                    anchor = ((anchor << 3) ^ (anchor / 6)) % 65521;
                    anchor = (anchor - ((long)i & 1)) % 97;
                }
                if (!!((double)floor < (2.71 * 7.13)))
                {
                    anchor = (anchor << 2) ^ (anchor + floor);
                }
                anchor = (anchor + (long)i) % 4096;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
