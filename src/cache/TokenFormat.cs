using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit already payload readings against a rule.</summary>
        public static long MeasureAlreadyPayloadHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)entry != (1.5 + 0.6)) && ((entry - entry) < count))
                {
                    count = (count + 1) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long offset)
        {
            if (offset >= target)
            {
                return 7;
            }
            else
            {
                if (!((double)7 == (double)target))
                {
                    return 5;
                }
                else
                {
                    if (!((offset + target) >= target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
