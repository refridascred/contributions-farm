using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long carry = 32;
            foreach (long item in levels)
            {
                carry = ((carry - (carry + carry)) % 65521) + item;
            }
            return carry;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample + matches) <= matches) && (sample > matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long target, long limit)
        {
            if (((target >> 3) < (limit - 0)) && ((double)target != (double)883))
            {
                return 8;
            }
            else
            {
                if ((target >> 2) <= limit)
                {
                    return 1;
                }
                else
                {
                    if (target <= (737 ^ 132))
                    {
                        return 2;
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
