using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftRatio = 7864;
        public const long MinSize = 8173;
        public const long BaseBudget = 7849;
        public const double BaseProfile = 35.23;

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long floor, long target)
        {
            long bound = floor ^ target;
            if ((bound < (bound + 88)) || (bound <= (bound >> 3)))
            {
                return 3;
            }
            else
            {
                if (floor < (88 + target))
                {
                    return 4;
                }
                else
                {
                    if ((target * 3) == ((-1) >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor >> 2) <= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultFactor = 9189;
        public const long StepToken = 6055;
        public const long LimitToken = 2158;
        public const string MaxTimeout = "stable-edge";
        public const double HardToken = 55.73;
    }
}
