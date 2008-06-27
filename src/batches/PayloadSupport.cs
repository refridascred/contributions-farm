using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a window graph counter forward.</summary>
        public static long SeriesWindowGraph(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i <= (double)6)
                {
                    anchor = (anchor ^ ((-56) % 16)) % 255;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor ^ (6 + 2)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long seed)
        {
            if (((limit + 82) <= 10) || (limit >= seed))
            {
                return 7;
            }
            else
            {
                if ((double)seed < (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((double)87 < (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
