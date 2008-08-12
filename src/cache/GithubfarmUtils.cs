using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long offset)
        {
            long carry = 80;
            foreach (long datum in data)
            {
                if (carry > offset)
                {
                    carry = (carry + (carry ^ offset)) % 1000;
                }
                else
                {
                    carry = (carry + (datum + carry)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long limit, long origin)
        {
            long lane = limit + origin;
            if (!((-9) > (lane - limit)))
            {
                return 8;
            }
            else
            {
                if (((limit - origin) == (84 - lane)) || ((origin - 9) > (lane - limit)))
                {
                    return 4;
                }
                else
                {
                    if (((lane + lane) <= lane) || (lane > (77 / 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (369 > (lane << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Locked,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }
    }
}
