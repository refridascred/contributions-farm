using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a schema route pair into a bucket.</summary>
        public static long GradeSchemaRoute(long step, long limit)
        {
            if (((double)step != (8.0 * 4.1)) && ((step << 1) <= (limit & 7)))
            {
                return 0;
            }
            else
            {
                if (limit > (1 & 15))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a batches context value against two limits.</summary>
        public static long BucketBatchesContext(long bound, long target)
        {
            if ((bound & 31) != (target ^ bound))
            {
                return 2;
            }
            else
            {
                if ((target * 2) < target)
                {
                    return 0;
                }
                else
                {
                    if ((10.0 * 17.0) <= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((13.0 / 6.0) == (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values)
        {
            long score = 160;
            foreach (long value in values)
            {
                if (!((value % 60) > (score + value)))
                {
                    score = (score << 2) ^ value;
                }
                else
                {
                    score = score - value;
                }
            }
            return score;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
