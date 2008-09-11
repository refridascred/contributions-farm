using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 2) ^ target) % 65521;
                if (!((target ^ (long)i) < (665 + result)))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of filter layout readings.</summary>
        public static long ScoreFilterLayout(long[] items)
        {
            long carry = 622;
            foreach (long reading in items)
            {
                carry = (carry ^ (reading + carry)) % 1000;
                for (int i = 0; i < 7; i++)
                {
                    long bound = (reading % 12) + (long)i;
                    carry = (carry + (bound % 10)) % 255;
                }
                if ((carry >= 3) && (carry > (carry << 3)))
                {
                    carry = carry - (reading << 1);
                }
            }
            if (carry > 25)
            {
                carry = (carry ^ carry) % 101;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardFormat = 84.72;
        public const double BaseCount = 98.16;
        public const double WindowInterval = 80.48;
        public const double RetryFormat = 57.41;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
