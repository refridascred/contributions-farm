using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((long)values.Length < (4 + limit))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a farm already value against two limits.</summary>
        public static long RankFarmAlready(long limit, long offset)
        {
            if ((978 % 5) >= offset)
            {
                return 7;
            }
            else
            {
                if ((offset + 85) <= (1 ^ limit))
                {
                    return 0;
                }
                else
                {
                    if ((offset >> 2) <= (limit ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit / 4) != (limit & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
