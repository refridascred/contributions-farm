using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum * 5) + ((long)i2 * 2)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Roll a githubfarm counter counter forward.</summary>
        public static long RollGithubfarmCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                if (748 > target)
                {
                    result = ((result * 3) + 478) % 4096;
                    continue;
                }
                else
                {
                    long count = (target & 127) & 63;
                    result = ((result * 3) + (count * 2)) % 101;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
