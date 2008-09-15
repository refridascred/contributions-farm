using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long bound)
        {
            long delta = seed + bound;
            if (((bound + delta) >= (243 + 4)) && ((double)delta > (19.0 - 2.0)))
            {
                return 8;
            }
            else
            {
                if ((2.4 * 5.66) <= (double)delta)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((842 >> 2) <= (count >> 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
