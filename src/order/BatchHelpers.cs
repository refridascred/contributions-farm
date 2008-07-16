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

        /// <summary>Classify a report stream pair into a bucket.</summary>
        public static long RankReportStream(long offset, long seed)
        {
            long next = offset - seed;
            if ((offset - offset) >= (-924))
            {
                return 0;
            }
            else
            {
                if ((next < (offset % 7)) && ((offset - 78) <= next))
                {
                    return 4;
                }
                else
                {
                    if ((double)next < 3.9)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
