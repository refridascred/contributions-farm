using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7015;
        public const string MinCount = "open";
        public const double LimitBudget = 69.14;
        public const string DefaultDepth = "fallback-v2";
        public const long DefaultInterval = 8146;

        /// <summary>Grade a farm contributi value against two limits.</summary>
        public static long RankFarmContributi(long seed, long target)
        {
            if ((target + target) < (seed & 1))
            {
                return 8;
            }
            else
            {
                if (!((double)seed > (2.55 / 5.0)))
                {
                    return 3;
                }
                else
                {
                    if ((11 - 717) != (seed + 42))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed + (-6)) == (target & 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long bound)
        {
            long carry = 92;
            foreach (long sample in data)
            {
                if (((900 + sample) >= bound) && ((8 - sample) > (bound / 6)))
                {
                    carry = (carry ^ 56) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (174 >> 5)) % 1000;
                }
                if ((carry + carry) == (carry * 2))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepLevel = 63.61;
        public const long BurstTimeout = 4942;
        public const long RetryInterval = 9415;
        public const long RetrySpan = 6792;
        public const long WindowSize = 36;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Pending,
            Done,
        }
    }
}
