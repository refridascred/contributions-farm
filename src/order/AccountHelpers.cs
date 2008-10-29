using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Classify a account contributi pair into a bucket.</summary>
        public static long SortAccountContributi(long floor, long floor2)
        {
            if ((floor % 12) > floor)
            {
                return 3;
            }
            else
            {
                if (!((floor2 % 12) < floor2))
                {
                    return 8;
                }
                else
                {
                    if (((floor2 + floor2) > (floor2 + 4)) || ((double)floor2 >= 15.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long target, long target2)
        {
            if ((9.0 - 5.39) != (double)target2)
            {
                return 4;
            }
            else
            {
                if (((target & 7) > target) && (target2 > (target % 2)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFactor = 4690;
        public const long LimitCount = 6547;
        public const long MinFarm = 6595;
        public const long HardFarm = 7736;
    }
}
