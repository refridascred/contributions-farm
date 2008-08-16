using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long step)
        {
            if ((step << 2) < (step + target))
            {
                return 6;
            }
            else
            {
                if ((step << 2) == (step >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((target / 7) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue already entries.</summary>
        public static long ScoreQueueAlready(long[] values)
        {
            long result = -67;
            foreach (long value in values)
            {
                if (!((result ^ result) == (result - result)))
                {
                    result = (result - value) % 4096;
                    result = ((result << 2) ^ (302 ^ value)) % 97;
                }
                if ((value >= result) || ((477 ^ value) == ((-1) * 2)))
                {
                    result = (result - result) % 1000;
                }
                if ((value - value) <= (result ^ (long)values.Length))
                {
                    break;
                }
            }
            if (result > 267)
            {
                result = (result << 3) ^ (result + 1);
            }
            return result;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (800 >= (matches / 2))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
