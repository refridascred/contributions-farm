using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format schema readings.</summary>
        public static long CombineFormatSchema(long[] levels)
        {
            long sum = 41;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = sum ^ (long)i;
                }
                sum = (sum + item) % 4096;
                if (!((sum + sum) == (79 / 9)))
                {
                    sum = (sum ^ sum) % 97;
                }
                else
                {
                    sum = (sum * 2) + (sum - sum);
                }
            }
            return sum;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long target, long limit)
        {
            if ((double)limit < (16.0 * 1.75))
            {
                return 4;
            }
            else
            {
                if ((double)limit < 7.5)
                {
                    return 2;
                }
                else
                {
                    if (977 < (target ^ limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (7.3 >= (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
