using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc * 5) + (122 / 7);
                if (acc > (floor - floor))
                {
                    acc = (acc * 3) + (long)i;
                    acc = (acc + (4 % 64)) % 1000;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Queued,
            Active,
            Pending,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitCount = 1373;
        public const long LimitBudget = 7466;
        public const string MinTimeout = "staging";
        public const long SoftDepth = 2618;
        public const long MinFilter = 5787;

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] items)
        {
            long mix = 4;
            foreach (long entry in items)
            {
                mix = ((mix * 3) + (entry >> 1)) % 255;
                mix = mix - (mix % 3);
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 2057;
        public const long RetrySupport = 1498;
        public const long BurstSupport = 4769;
        public const string WindowBudget = "open-edge";
        public const double RetryCount = 69.72;
    }
}
