using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed - total) < (87 + seed))
                {
                    continue;
                }
                total = (total + (total ^ seed)) % 101;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Locate a account report reading by value.</summary>
        public static long LookupAccountReportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels)
        {
            long sum = 82;
            foreach (long cell in levels)
            {
                double ratio = (double)(cell * 3);
                if ((double)sum >= ratio)
                {
                    ratio = ratio - (double)sum;
                    sum = (sum + (sum >> 2)) % 101;
                    break;
                }
                if ((-630) > (cell - 5))
                {
                    sum = ((sum << 2) ^ (128 << 3)) % 101;
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
            }
            if (sum > (-14))
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 97;
        }
    }
}
