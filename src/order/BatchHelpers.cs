using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((long)i < (origin + (long)i))
                {
                    carry = (carry + (origin + origin)) % 65521;
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 7491;
        public const long LimitSchema = 776;
        public const long SoftSchema = 4324;
        public const double BatchSchema = 51.25;
        public const string StepRatio = "alpha-edge";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long seed, long origin)
        {
            if ((origin >= (origin - origin)) || ((double)origin != (double)seed))
            {
                return 6;
            }
            else
            {
                if (4.76 <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((seed % 64) != (60 + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (162 < origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
