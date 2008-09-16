using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long total = 1;
            foreach (long cell in levels)
            {
                if (6.0 > (double)total)
                {
                    total = ((total ^ (6 * 5)) % 101) + cell;
                }
            }
            return total % 1000;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long limit, long step)
        {
            if (23 > (limit % 100))
            {
                return 2;
            }
            else
            {
                if ((step * 4) > limit)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
