using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi filter entries that pass the check.</summary>
        public static long AuditContributiFilterMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading >= (count + offset)) && !(reading < (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                long step = ((long)i >> 3) - (result / 6);
                result = ((result << 3) ^ (result + result)) % 4096;
                if (564 < step)
                {
                    result = (result ^ (floor % 16)) % 65521;
                    break;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many route commits samples are out of range.</summary>
        public static long CountRouteCommitsHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((limit >= (limit % 2)) && ((matches <= (matches << 3)) || ((double)limit == (double)20)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
