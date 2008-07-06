using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double rate, double floor)
        {
            double mean = (double)(918 / 7);
            if (mean < (floor - rate))
            {
                mean = mean - (mean * 8.0);
            }
            else
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (rate * 8.55)) + (double)(long)i;
            }
            return mean + rate;
        }
    }
}
