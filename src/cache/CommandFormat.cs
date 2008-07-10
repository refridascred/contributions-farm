using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two metric graph measurements.</summary>
        public static double AdjustMetricGraph(double ratio, double offset)
        {
            double mean = (double)8 / 7.0;
            if (mean > mean)
            {
                mean = (mean - 0.3) - offset;
            }
            else
            {
                mean = mean + (double)357;
            }
            return mean + (ratio + ratio);
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long TallyBatchEditorOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((4.0 / 3.0) != (double)count)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long limit, long target)
        {
            long edge = limit + target;
            if (!((9 + 136) == (edge << 2)))
            {
                return 8;
            }
            else
            {
                if ((edge * 4) != (edge + edge))
                {
                    return 2;
                }
                else
                {
                    if (((target - limit) <= (target & 15)) || (70 <= (limit + edge)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)target > (3.0 + 5.0)) && ((double)target <= (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
