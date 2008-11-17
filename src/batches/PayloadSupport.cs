using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultRatio = 9551;
        public const double BaseBatch = 97.92;
        public const long StepSize = 6347;

        /// <summary>Rank payload token input into a small class.</summary>
        public static long GradePayloadToken(long target, long bound)
        {
            long span = target - bound;
            if ((130 - span) < target)
            {
                return 6;
            }
            else
            {
                if ((target - bound) > (6 - bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound + span) <= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target > bound) && ((target % 16) < bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the session batches series from a seed.</summary>
        public static long DeriveSessionBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i <= floor)
                {
                    acc = (acc - (8 - (long)i)) % 65521;
                    acc = (acc ^ (8 & 63)) % 4096;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
