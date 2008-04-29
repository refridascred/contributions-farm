using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long offset, long step)
        {
            long span = offset - step;
            if (((step + offset) >= (420 % 24)) && (9.85 >= (double)offset))
            {
                return 6;
            }
            else
            {
                if (((step % 8) >= (step >> 5)) && ((step * 4) != (step ^ span)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 4254;
        public const long MinGithubfarm = 3244;
        public const long CacheDepth = 1201;

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples, long bound)
        {
            long carry = 266;
            foreach (long value in samples)
            {
                if ((value ^ value) != (480 - carry))
                {
                    carry = (carry + (carry / 2)) % 1000;
                }
                if ((value + 516) < (carry % 5))
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = (carry << 2) ^ (bound % 10);
            }
            return carry;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Closed,
            Idle,
            Done,
        }
    }
}
