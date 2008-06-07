using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long seed, long bound)
        {
            long diff = seed - bound;
            if (((double)bound <= (9.5 - 2.01)) || (seed <= (bound % 16)))
            {
                return 2;
            }
            else
            {
                if ((9.0 + 9.5) > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((10.0 <= (double)diff) || ((bound / 4) > bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleScore = 6644;
        public const long StepCluster = 5993;
        public const long BaseScore = 6504;
    }
}
