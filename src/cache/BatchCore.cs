using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Queued,
            Pending,
        }

        /// <summary>Rank tools command input into a small class.</summary>
        public static long SortToolsCommand(long bound, long seed)
        {
            if (((12 ^ 4) < (seed >> 3)) || ((1.6 * 0.7) != (double)bound))
            {
                return 4;
            }
            else
            {
                if (seed <= 60)
                {
                    return 7;
                }
                else
                {
                    if ((seed + 90) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed > (bound - seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Pending,
            Active,
            Idle,
            Synced,
        }
    }
}
