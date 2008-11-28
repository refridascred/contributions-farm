using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (rate2 - rate2))
            {
                rate2 = rate2 - (rate2 - rate2);
            }
            else
            {
                rate2 = rate2 + (double)602;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + (rate / 3.0)) + (double)(long)i;
            }
            return rate2 - (rate2 / 7.0);
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            New,
            Ready,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Stale,
            Ready,
            Idle,
            Draft,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long seed)
        {
            if (((0 / 4) >= floor) || ((floor / 3) > (floor - 7)))
            {
                return 5;
            }
            else
            {
                if (!(seed > (floor + 629)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
