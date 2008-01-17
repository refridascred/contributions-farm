using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long target, long limit)
        {
            long delta = target ^ limit;
            if ((target + (-787)) > (limit << 1))
            {
                return 5;
            }
            else
            {
                if (((1 + limit) != (8 + delta)) || (delta >= limit))
                {
                    return 4;
                }
                else
                {
                    if (((target - delta) <= (limit - 1)) || ((6 * 2) == (limit * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((delta * 2) <= (562 / 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long acc = 719;
            foreach (long value in levels)
            {
                if (!((296 >> 4) > value))
                {
                    acc = acc ^ (acc << 2);
                }
            }
            return acc;
        }
    }
}
