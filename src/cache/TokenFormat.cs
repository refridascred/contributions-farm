using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long step, long origin)
        {
            long delta = step ^ origin;
            if (1 >= (origin + (-945)))
            {
                return 2;
            }
            else
            {
                if ((origin >= delta) && (origin < (step * 5)))
                {
                    return 1;
                }
                else
                {
                    if (delta <= (delta + delta))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin % 24) > (delta - step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Synced,
            Pending,
            Failed,
        }
    }
}
