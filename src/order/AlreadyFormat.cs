using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long offset, long limit)
        {
            if ((double)limit > (10.0 / 5.0))
            {
                return 8;
            }
            else
            {
                if (limit <= (offset >> 1))
                {
                    return 7;
                }
                else
                {
                    if (((9.0 / 6.0) == (double)offset) && ((double)limit <= (1.82 * 12.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((12.0 + 20.0) < (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 85.74;
        public const string StepContributi = "primary-v2";
        public const string HardContributi = "fallback-1";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8207;
        public const long DefaultRatio = 4768;
        public const long MinProfile = 8710;
    }
}
