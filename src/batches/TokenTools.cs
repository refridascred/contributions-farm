using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Failed,
            Idle,
            Retry,
            New,
        }

        /// <summary>Measure how many commits token samples are out of range.</summary>
        public static long CountCommitsTokenOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((7.0 + 0.1) > (double)reading) || ((reading / 8) <= (hits ^ hits)))
                {
                    hits = (hits + 1) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
