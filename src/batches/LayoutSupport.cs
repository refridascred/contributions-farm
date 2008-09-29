using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading % 60) != (reading + 46))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultDepth = 8651;
        public const long BatchNotes = 6172;
        public const long DefaultWidth = 9713;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value >> 3) >= (2 * 4))
                {
                    seen = (seen + 1) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long seed)
        {
            long delta = origin + seed;
            if ((delta % 2) <= (seed / 9))
            {
                return 3;
            }
            else
            {
                if ((2.28 + 9.4) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((seed >> 2) < (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4 >> 2) != (delta / 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
