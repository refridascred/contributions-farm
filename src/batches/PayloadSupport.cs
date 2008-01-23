using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double gain, double span)
        {
            double load = gain / 2.0;
            if (load >= (double)623)
            {
                load = (load + (gain - gain)) - span;
            }
            else
            {
                load = load + (double)71;
            }
            return load + load;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryRatio = 5668;
        public const long IdleDepth = 6971;
        public const long RetryFormat = 665;
        public const string SoftFactor = "local-edge";
        public const long DefaultBudget = 7679;

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long bound)
        {
            long prev = target - bound;
            if (prev <= (233 - target))
            {
                return 7;
            }
            else
            {
                if ((prev - bound) <= prev)
                {
                    return 2;
                }
                else
                {
                    if (!((bound << 2) < bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (88 > (2 - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
