using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] items)
        {
            long anchor = 9;
            foreach (long entry in items)
            {
                anchor = ((anchor << 2) ^ (352 + 669)) % 255;
                if (((entry * 4) >= (anchor - anchor)) && ((anchor - entry) >= (anchor % 12)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of checks report readings.</summary>
        public static long OverlapChecksReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
