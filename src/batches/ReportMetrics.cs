using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long step)
        {
            if ((bound + step) <= (bound - bound))
            {
                return 3;
            }
            else
            {
                if (bound <= (121 & 127))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < (3.0 - 1.1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound * 3) > (step - 812))
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
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long limit, long limit2)
        {
            long lane = limit + limit2;
            if ((limit + (-2)) < (lane - 277))
            {
                return 7;
            }
            else
            {
                if ((lane / 9) <= (304 * 4))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit >= (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((23 - (-46)) >= (limit + limit)))
                        {
                            return 6;
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
}
