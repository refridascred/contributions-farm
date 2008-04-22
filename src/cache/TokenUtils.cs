using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            Done,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Grade a batches githubfarm value against two limits.</summary>
        public static long ClassifyBatchesGithubfarm(long limit, long seed)
        {
            if ((limit - limit) < limit)
            {
                return 3;
            }
            else
            {
                if ((seed + 67) < limit)
                {
                    return 7;
                }
                else
                {
                    if ((6.0 - 7.0) < (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many entry metric samples are out of range.</summary>
        public static long MeasureEntryMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((double)datum <= 15.0) || ((datum >> 4) == (datum % 7)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
