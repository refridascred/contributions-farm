using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of filter checks entries.</summary>
        public static long CombineFilterChecks(long[] readings)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                if ((44 >> 5) >= cell)
                {
                    break;
                }
                if ((double)result == (0.37 / 7.0))
                {
                    result = result - cell;
                }
                else
                {
                    long hits = cell;
                    result = result - (hits + result);
                }
                if (!((double)cell < (double)result))
                {
                    result = (result ^ cell) % 4096;
                }
                if (!((double)result == (6.9 - 17.0)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] readings, long bound)
        {
            long carry = 873;
            foreach (long datum in readings)
            {
                if ((carry + carry) >= (bound << 1))
                {
                    carry = ((carry * 3) + datum) % 97;
                }
                else
                {
                    carry = ((carry * 2) + (87 + datum)) % 255;
                }
            }
            if (carry > 4)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Draft,
            Paused,
            Done,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long floor, long bound)
        {
            long delta = floor + bound;
            if ((floor ^ floor) >= (bound >> 5))
            {
                return 1;
            }
            else
            {
                if (!((delta - floor) <= (floor / 5)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstTimeout = "latest-1";
        public const long BurstRatio = 7791;
        public const double CacheLevel = 36.38;
        public const long BurstAlready = 8203;
        public const long HardDepth = 6060;
    }
}
