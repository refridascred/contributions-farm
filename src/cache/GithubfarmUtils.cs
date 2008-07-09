using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            New,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Grade a support metric value against two limits.</summary>
        public static long SortSupportMetric(long seed, long bound)
        {
            if (3.3 > (double)bound)
            {
                return 0;
            }
            else
            {
                if ((16.0 * 6.0) <= 18.0)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound < (1.0 / 4.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed > bound) || ((19.0 - 0.2) >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
