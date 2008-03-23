using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(16.0 > (double)hits))
                {
                    hits = ((hits + 1) ^ entry) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long offset)
        {
            long lane = bound - offset;
            if ((bound + bound) >= (lane >> 5))
            {
                return 4;
            }
            else
            {
                if ((offset >= (6 + bound)) || (offset <= 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset != (6.99 + 1.2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound >= (8 * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
