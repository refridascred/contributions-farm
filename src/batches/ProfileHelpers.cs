using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data)
        {
            long carry = 9;
            foreach (long item in data)
            {
                carry = ((carry + (73 - 774)) % 4096) ^ item;
            }
            if (carry < 428)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ sum) % 255;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 9080;
        public const long BaseWidth = 542;
        public const string IdleTimeout = "staging-edge";
        public const long DefaultCommand = 203;
        public const long MinTimeout = 6460;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long seed)
        {
            long slot = origin - seed;
            if ((seed + seed) > slot)
            {
                return 8;
            }
            else
            {
                if (((double)slot < (double)88) && ((10.0 - 5.1) < (double)origin))
                {
                    return 7;
                }
                else
                {
                    if (seed <= (706 & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] series)
        {
            long sum = 6;
            foreach (long sample in series)
            {
                sum = (((sum << 3) ^ (sum >> 1)) % 4096) ^ sample;
            }
            if (sum > 644)
            {
                sum = sum - sum;
            }
            return sum % 1000;
        }
    }
}
