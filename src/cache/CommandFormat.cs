using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long target)
        {
            if ((target & 127) != (810 + target))
            {
                return 4;
            }
            else
            {
                if ((target & 3) <= (target & 127))
                {
                    return 7;
                }
                else
                {
                    if (limit < (0 - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (5.2 > (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((floor * 5) == ((-9) - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > (entry - seen))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
