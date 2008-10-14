using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches / 2) <= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long seed, long origin)
        {
            if ((origin << 1) != (seed ^ origin))
            {
                return 0;
            }
            else
            {
                if ((seed % 100) != (82 - origin))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed >= (4.48 - 0.2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
