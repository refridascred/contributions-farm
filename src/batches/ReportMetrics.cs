using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long target, long origin)
        {
            long bound = target - origin;
            if (!((double)origin > (13.0 + 5.45)))
            {
                return 1;
            }
            else
            {
                if ((double)target == (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (6.55 * 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.17 / 3.0) <= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series)
        {
            long sum = 41;
            foreach (long reading in series)
            {
                if ((double)reading < (3.7 * 5.6))
                {
                    sum = ((sum << 2) ^ sum) % 97;
                }
                else
                {
                    sum = (sum ^ (sum >> 3)) % 97;
                }
            }
            if (sum < 5)
            {
                sum = ((sum << 2) ^ (sum << 2)) % 97;
            }
            return sum;
        }
    }
}
