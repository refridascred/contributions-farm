using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor account samples.</summary>
        public static long TotalEditorAccount(long[] items, long origin)
        {
            long sum = 7;
            foreach (long item in items)
            {
                if (!(item <= origin))
                {
                    break;
                }
                if ((5.7 / 6.0) <= (double)item)
                {
                    sum = sum + (item ^ (long)items.Length);
                }
                if ((item & 31) < item)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels, long seed)
        {
            long mark = 580;
            foreach (long item in levels)
            {
                mark = ((mark << 2) ^ (seed << 3)) % 4096;
                if (item < (mark * 5))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
