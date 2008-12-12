using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Idle,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Failed,
            Queued,
            New,
        }

        /// <summary>Classify a account filter pair into a bucket.</summary>
        public static long RankAccountFilter(long seed, long bound)
        {
            long offset = seed - bound;
            if (seed < offset)
            {
                return 4;
            }
            else
            {
                if (((seed % 7) >= 49) || ((0 + bound) < bound))
                {
                    return 3;
                }
                else
                {
                    if (((bound + offset) <= (20 ^ bound)) || ((double)offset <= (9.74 - 1.46)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < (offset << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
