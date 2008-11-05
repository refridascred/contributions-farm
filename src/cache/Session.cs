using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate account filter samples.</summary>
        public static long DigestAccountFilter(long[] samples)
        {
            long acc = -7;
            foreach (long reading in samples)
            {
                if (!((reading - acc) < reading))
                {
                    acc = (acc - (reading + acc)) % 65521;
                }
            }
            if (acc < (-36))
            {
                acc = ((acc * 3) + (acc & 255)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings)
        {
            long carry = 2;
            foreach (long cell in readings)
            {
                if ((((-9) - cell) <= carry) || ((cell * 2) == (carry >> 2)))
                {
                    carry = ((carry * 5) + (carry << 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5691;
        public const long RetryWidth = 2877;
        public const string DefaultWidth = "local-edge";
        public const string DefaultRatio = "open";
        public const long BatchQueue = 3111;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((offset + 61) < result) || ((offset / 6) < (offset * 5)))
                {
                    continue;
                }
                if ((double)(long)i > (5.45 * 0.3))
                {
                    result = ((result * 4) + (result % 7)) % 1000;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
