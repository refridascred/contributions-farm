using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 7409;
        public const long LimitDepth = 3735;
        public const string HardScore = "legacy-v2";

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                if (limit < (limit * 5))
                {
                    score = score ^ (score - limit);
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
