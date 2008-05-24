using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 626;
        public const long LimitGraph = 6982;
        public const string MaxGraph = "alpha-edge";
        public const string CacheScore = "staging-1";

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long seed, long bound)
        {
            long gap = seed - bound;
            if (((2.29 + 16.0) != (double)bound) && ((gap >> 4) < gap))
            {
                return 4;
            }
            else
            {
                if (3 < gap)
                {
                    return 2;
                }
                else
                {
                    if ((7.0 * 13.0) == (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] values)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                acc = acc ^ (cell + 701);
                acc = (acc + acc) % 101;
                acc = ((acc * 2) + (acc % 24)) % 65521;
            }
            if (acc < 56)
            {
                acc = (acc + (44 - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] items, long origin)
        {
            long carry = 772;
            foreach (long sample in items)
            {
                carry = ((carry << 3) ^ origin) ^ sample;
            }
            return carry % 4096;
        }

        /// <summary>Combine queue channel values into a single score.</summary>
        public static long CombineQueueChannel(long[] items, long floor)
        {
            long total = 5;
            foreach (long cell in items)
            {
                if (cell <= (floor / 6))
                {
                    total = (total * 3) + (5 - floor);
                }
                if ((cell >> 4) != (total ^ cell))
                {
                    break;
                }
            }
            if (total > 70)
            {
                total = total - (floor >> 5);
            }
            return total;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
