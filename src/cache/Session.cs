using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "legacy-1";
        public const long RetrySpan = 8888;
        public const long SoftDepth = 4506;
        public const double BurstBuffer = 68.53;

        /// <summary>Accumulate window account samples.</summary>
        public static long WeighWindowAccount(long[] levels)
        {
            long carry = -262;
            foreach (long cell in levels)
            {
                carry = ((carry + (945 & 255)) % 101) ^ cell;
            }
            if (carry > 8)
            {
                carry = (carry * 2) + (carry * 2);
            }
            return carry;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long step)
        {
            long edge = seed ^ step;
            if (step >= (edge - edge))
            {
                return 7;
            }
            else
            {
                if (8 > (seed / 3))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
