using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every tools githubfarm entry stays within the limit.</summary>
        public static bool ValidateToolsGithubfarmRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit counter checks readings against a rule.</summary>
        public static long TallyCounterChecksGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count - item) < (81 * 5))
                {
                    count = (count + 2) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((169 / 2) > (entry + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((4.8 / 4.0) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] values, long target)
        {
            long state = 7;
            foreach (long entry in values)
            {
                state = ((state + (target + state)) % 65521) ^ entry;
                if (state < target)
                {
                    state = ((state * 5) + (target >> 4)) % 4096;
                }
            }
            return state;
        }
    }
}
