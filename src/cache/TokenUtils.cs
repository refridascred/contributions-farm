using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] samples, long origin)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                state = ((state - (state + state)) % 101) - origin;
                state = state - (datum << 3);
                if ((double)state > (20.0 - 7.3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((double)sum < (1.33 + 7.0)) || (bound >= (bound & 31)))
                {
                    sum = ((sum << 3) ^ 865) % 4096;
                }
                else
                {
                    sum = (sum ^ bound) % 4096;
                    sum = (sum << 2) ^ bound;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (sum - ((long)i / 5)) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
