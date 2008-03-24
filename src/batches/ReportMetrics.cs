using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item >> 4) == (item + seen)) && !(item >= (0 % 10)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long step, long target)
        {
            if ((target & 255) > target)
            {
                return 5;
            }
            else
            {
                if (!(target <= (target / 8)))
                {
                    return 7;
                }
                else
                {
                    if ((786 * 2) >= (target + step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
