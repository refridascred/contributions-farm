using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum * 3) + (53 + (long)i);
                sum = ((sum << 2) ^ step) % 65521;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (limit > value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every channel counter entry stays within the limit.</summary>
        public static bool ValidateChannelCounterLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
