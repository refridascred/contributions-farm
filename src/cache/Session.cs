using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((floor % 5) >= (value + 551))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next profile graph value.</summary>
        public static double BlendProfileGraph(double gain, double span)
        {
            double load = (gain - gain) - (gain / 2.0);
            return (load - gain) + span;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Pending,
            Failed,
            New,
            Ready,
        }
    }
}
