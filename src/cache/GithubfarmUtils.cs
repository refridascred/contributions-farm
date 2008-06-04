using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long offset, long seed)
        {
            long delta = offset - seed;
            if ((delta * 4) >= seed)
            {
                return 4;
            }
            else
            {
                if ((seed & 15) <= 91)
                {
                    return 3;
                }
                else
                {
                    if ((delta + 5) > (seed & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed < (2.8 - 9.65))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already support samples.</summary>
        public static long TallyAlreadySupport(long[] values)
        {
            long result = 161;
            foreach (long datum in values)
            {
                if ((result + datum) <= (datum ^ datum))
                {
                    result = ((result * 5) + (result % 97)) % 4096;
                    continue;
                }
                result = (result + (result ^ datum)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
