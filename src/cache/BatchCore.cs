using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank channel stats input into a small class.</summary>
        public static long SortChannelStats(long step, long origin)
        {
            long prev = step ^ origin;
            if ((441 * 4) != (origin + step))
            {
                return 6;
            }
            else
            {
                if (!((67 >> 1) <= (origin + origin)))
                {
                    return 8;
                }
                else
                {
                    if ((double)prev >= (5.0 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin < prev)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values)
        {
            long score = 65;
            foreach (long cell in values)
            {
                score = (score ^ (cell >> 2)) % 97;
            }
            return score % 97;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((matches & 63) == (cell / 6)) || (((cell + cell) > (cell << 3)) && ((double)cell < (14.0 - 0.4))))
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
