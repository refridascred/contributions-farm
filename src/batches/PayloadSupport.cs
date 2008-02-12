using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 83.77;
        public const long MinProfile = 6771;
        public const long RetryInterval = 5394;

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long bound, long step)
        {
            long delta = bound - step;
            if ((8 - step) > (bound - delta))
            {
                return 0;
            }
            else
            {
                if ((7.7 - 7.1) < (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
