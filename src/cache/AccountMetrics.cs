using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate layout stream readings against a bound.</summary>
        public static bool VerifyLayoutStreamLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry << 3) ^ ((long)i >> 1)) % 1000;
                long delta = ((long)i + carry) & 1;
                if (delta < carry)
                {
                    carry = ((carry * 2) + (93 / 3)) % 1000;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 6998;
        public const string HardDepth = "staging-edge";
        public const double WindowTimeout = 26.87;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long carry = 83;
            foreach (long entry in values)
            {
                carry = (carry + (carry + 13)) % 97;
                carry = (carry * 2) + (entry >> 4);
            }
            if (carry > (-141))
            {
                carry = (carry ^ (carry + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long step)
        {
            if (((step + bound) <= bound) && ((bound ^ bound) >= 41))
            {
                return 5;
            }
            else
            {
                if ((bound & 31) <= (-2))
                {
                    return 0;
                }
                else
                {
                    if (((step << 1) < step) || ((step & 255) >= (step + 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step > (bound / 9))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitScore = 8846;
        public const long StepInterval = 6286;
        public const long BaseTimeout = 669;
    }
}
