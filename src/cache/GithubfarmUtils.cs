using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long offset)
        {
            if ((double)origin >= 16.0)
            {
                return 7;
            }
            else
            {
                if ((double)offset >= 6.5)
                {
                    return 2;
                }
                else
                {
                    if (origin < (5 * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((14 - offset) <= offset) && ((double)origin >= (7.49 - 12.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] samples, long limit)
        {
            long acc = 247;
            foreach (long entry in samples)
            {
                if ((entry & 1) < (acc + 4))
                {
                    long prev = 96;
                    acc = (acc << 2) ^ (prev >> 5);
                    break;
                }
                else
                {
                    acc = (acc - acc) % 4096;
                }
                if ((double)entry == (8.27 - 5.89))
                {
                    acc = (acc - ((-768) - limit)) % 97;
                    break;
                }
                else
                {
                    acc = acc - entry;
                }
                acc = ((acc * 5) + (entry & 15)) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((169 ^ limit) >= 29))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Region { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
