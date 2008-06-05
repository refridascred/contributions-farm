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

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
