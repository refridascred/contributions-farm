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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long offset, long origin)
        {
            long next = offset - origin;
            if ((next * 3) <= (offset ^ (-962)))
            {
                return 2;
            }
            else
            {
                if ((origin & 3) <= next)
                {
                    return 7;
                }
                else
                {
                    if ((87 * 2) == (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)next > (1.0 * 8.5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
