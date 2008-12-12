using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = -7;
            foreach (long item in readings)
            {
                if ((item - carry) <= (carry - 68))
                {
                    carry = (carry + ((-778) - carry)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Grade a batches context value against two limits.</summary>
        public static long BucketBatchesContext(long bound, long target)
        {
            if ((bound & 31) != (target ^ bound))
            {
                return 2;
            }
            else
            {
                if ((target * 2) < target)
                {
                    return 0;
                }
                else
                {
                    if ((10.0 * 17.0) <= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((13.0 / 6.0) == (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 4381;
        public const string LimitFactor = "local-v2";
        public const long WindowRatio = 9776;
        public const double MinBudget = 75.77;
        public const long BaseChannel = 2426;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
