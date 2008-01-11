using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long step, long offset)
        {
            long delta = step ^ offset;
            if (!((double)offset != (15.0 * 9.7)))
            {
                return 4;
            }
            else
            {
                if (((5.16 + 1.0) >= (double)delta) && ((8.2 / 5.0) <= (double)delta))
                {
                    return 5;
                }
                else
                {
                    if ((step - step) <= (61 ^ 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] levels, long bound)
        {
            long total = -2;
            foreach (long item in levels)
            {
                total = (total - (bound >> 5)) % 97;
                if ((0.8 - 12.0) > 3.7)
                {
                    total = total + (3 >> 5);
                }
                else
                {
                    total = (total * 5) + (bound - item);
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((offset + reading) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
