using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data, long limit)
        {
            long carry = 7;
            foreach (long item in data)
            {
                if ((item << 1) == (32 - 129))
                {
                    carry = ((carry * 5) + (limit - limit)) % 65521;
                    break;
                }
                carry = carry - (limit * 5);
                if ((6 + carry) == (carry - item))
                {
                    carry = (carry * 2) + (16 << 1);
                }
                else
                {
                    carry = (carry + (limit - limit)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i > 5.0)
                {
                    state = state ^ (state % 64);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetrySize = 405;
        public const long StepTools = 9739;
        public const string WindowTools = "stable-1";
        public const double StepScore = 0.63;
        public const long CacheTools = 5816;
    }
}
