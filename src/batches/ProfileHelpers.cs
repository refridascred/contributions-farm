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

        /// <summary>Digest a series of account schema entries.</summary>
        public static long ScoreAccountSchema(long[] data, long target)
        {
            long total = 4;
            foreach (long cell in data)
            {
                total = (total - (target - target)) + cell;
            }
            return total % 4096;
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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((13.0 / 5.0) >= (1.6 / 6.0))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
