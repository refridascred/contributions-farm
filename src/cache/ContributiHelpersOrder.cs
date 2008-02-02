using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long bound)
        {
            if ((0.6 / 4.0) == (double)offset)
            {
                return 6;
            }
            else
            {
                if ((bound + offset) != ((-5) & 15))
                {
                    return 1;
                }
                else
                {
                    if (offset > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.5 + 7.1) < (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
