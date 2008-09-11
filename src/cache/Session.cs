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

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!!((target + target) < (8 + target)))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
