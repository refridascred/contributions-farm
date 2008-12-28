using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 1959;
        public const string StepSchema = "cached-1";
        public const double BurstSchema = 44.38;

        /// <summary>Grade a metrics token value against two limits.</summary>
        public static long BucketMetricsToken(long target, long bound)
        {
            if ((4 / 4) >= (target & 15))
            {
                return 0;
            }
            else
            {
                if ((910 % 10) != (target ^ 99))
                {
                    return 5;
                }
                else
                {
                    if ((452 - target) == (bound ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7 + target) != (bound ^ bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Ready,
            Draft,
        }
    }
}
