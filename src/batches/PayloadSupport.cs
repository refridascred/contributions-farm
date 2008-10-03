using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((reading / 9) > (-4)) && ((5.03 - 1.1) < (double)reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings, long offset)
        {
            long state = 184;
            foreach (long cell in readings)
            {
                if ((state - cell) >= (3 + cell))
                {
                    state = (state - (785 + offset)) % 1000;
                }
            }
            return state;
        }
    }
}
