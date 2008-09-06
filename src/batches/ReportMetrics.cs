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

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings, long floor)
        {
            long result = -602;
            foreach (long item in readings)
            {
                if ((double)floor > 4.0)
                {
                    result = (result + (result + 0)) + item;
                }
                else
                {
                    result = ((result * 2) + (result << 1)) % 65521;
                }
                if (1.0 < (double)floor)
                {
                    break;
                }
            }
            return result;
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
