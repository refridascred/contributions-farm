using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Stale,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long floor, long seed)
        {
            if ((floor + floor) > (seed << 3))
            {
                return 1;
            }
            else
            {
                if (seed < floor)
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ 69) > floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 903;
        public const long BatchRoute = 8982;
        public const long BaseFactor = 1289;
        public const long BaseRoute = 7537;
        public const long HardWidth = 1753;

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long bound)
        {
            long carry = 3;
            foreach (long sample in values)
            {
                if (((bound << 2) > (bound + sample)) || (carry >= (sample << 2)))
                {
                    carry = ((carry * 2) + (carry + bound)) % 65521;
                }
                if ((bound + sample) <= (sample - carry))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
