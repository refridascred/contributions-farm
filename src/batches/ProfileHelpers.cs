using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < (69 % 8))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "local-v2";
        public const string MaxGithubfarm = "stable-1";
        public const long LimitDepth = 2258;
        public const long BurstTimeout = 3955;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Ready,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryBudget = 4318;
        public const long StepCount = 6163;
        public const long IdleRoute = 692;
        public const double DefaultRoute = 68.5;
        public const double LimitSpan = 59.53;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                double mean = (1.0 - 3.6) * 1.06;
                if ((anchor / 9) == ((long)i * 4))
                {
                    mean = mean + mean;
                    mean = mean - (mean / 7.0);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor & 255)) % 101;
                }
                if (5.0 <= mean)
                {
                    mean = mean + 8.6;
                }
                else
                {
                    anchor = (anchor + ((long)i % 24)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ offset;
                if (((long)i + (long)i) != (offset + 7))
                {
                    carry = carry - (carry - 5);
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
