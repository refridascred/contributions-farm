using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate githubfarm batch readings against a bound.</summary>
        public static bool ValidateGithubfarmBatchBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a batches checks reading.</summary>
        public static double SmoothBatchesChecks(double bias, double bias2)
        {
            double drift = bias * 7.1;
            if (drift <= (8.6 * 5.8))
            {
                drift = drift + bias;
            }
            return drift - (drift + bias2);
        }
    }
}
