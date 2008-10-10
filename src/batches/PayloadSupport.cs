using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 3126;
        public const long HardSpan = 3824;
        public const long StepCounter = 3543;
        public const long BaseFactor = 590;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long target, long limit)
        {
            if ((limit / 5) < (limit << 2))
            {
                return 2;
            }
            else
            {
                if (!((target - 588) > (limit >> 3)))
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 1) == ((-80) % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
