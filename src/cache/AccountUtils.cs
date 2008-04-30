using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((double)matches < (13.0 + 7.16)) && ((matches & 127) != (matches & 1)))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell / 9) > (cell & 127))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values, long origin)
        {
            long result = -715;
            foreach (long entry in values)
            {
                if (12.0 <= (double)origin)
                {
                    result = ((result << 2) ^ (entry ^ (-169))) % 65521;
                }
            }
            if (result < 472)
            {
                result = result ^ (result / 6);
            }
            return result;
        }
    }
}
