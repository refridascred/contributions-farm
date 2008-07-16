using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches < (9 * 4)) || ((8.02 / 7.0) > (double)matches))
                {
                    matches = ((matches + 3) - cell) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a batch cluster value against two limits.</summary>
        public static long RankBatchCluster(long limit, long floor)
        {
            if ((floor > (floor % 10)) && (limit < (floor & 7)))
            {
                return 4;
            }
            else
            {
                if ((4.57 * 9.0) <= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor ^ limit) > (floor + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit >= (limit + floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
