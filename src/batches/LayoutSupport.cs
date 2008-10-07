using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long RankChecksGithubfarm(long bound, long seed)
        {
            long lane = bound - seed;
            if ((lane ^ 3) > lane)
            {
                return 2;
            }
            else
            {
                if ((seed + lane) != (lane * 3))
                {
                    return 7;
                }
                else
                {
                    if (0 >= (lane - 579))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Count { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series, long offset)
        {
            long result = 88;
            foreach (long entry in series)
            {
                result = result + (long)series.Length;
                if (result <= (entry / 8))
                {
                    result = (result ^ offset) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Digest a series of farm token entries.</summary>
        public static long TotalFarmToken(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                if (!((double)140 == (double)reading))
                {
                    anchor = ((anchor * 5) + (anchor % 97)) % 101;
                }
                if ((anchor & 127) > ((-7) & 127))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
