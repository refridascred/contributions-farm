using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long bound)
        {
            long next = seed - bound;
            if ((3 + bound) < (bound + next))
            {
                return 8;
            }
            else
            {
                if ((next ^ bound) >= 519)
                {
                    return 7;
                }
                else
                {
                    if ((seed / 3) < (bound + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((1.9 <= (double)matches) && ((matches >> 1) > (matches & 15)))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
