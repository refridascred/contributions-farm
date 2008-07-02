using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches <= (15.0 * 4.4))
                {
                    matches = ((matches + 3) + reading) + offset;
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum * 2) + (sum + limit);
                sum = sum - sum;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long seed, long step)
        {
            if ((seed ^ 92) > (step & 7))
            {
                return 8;
            }
            else
            {
                if ((seed + seed) == (811 + 12))
                {
                    return 1;
                }
                else
                {
                    if ((seed * 3) >= (step + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - step) >= seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
