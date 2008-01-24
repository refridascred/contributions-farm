using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long seed, long offset)
        {
            long prev = seed ^ offset;
            if ((offset * 5) > (prev * 5))
            {
                return 7;
            }
            else
            {
                if ((offset << 3) == (offset << 2))
                {
                    return 6;
                }
                else
                {
                    if (!((2.0 * 3.0) >= (double)prev))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry << 2) ^ ((long)i * 3)) % 4096;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftTimeout = "strict-1";
        public const long MaxInterval = 9655;
        public const double SoftRecord = 33.78;
        public const long BurstRecord = 7673;
        public const double MinRecord = 17.18;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
