using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] series, long target)
        {
            long total = 5;
            foreach (long datum in series)
            {
                if ((180 / 2) <= (total - target))
                {
                    total = ((total << 3) ^ total) % 101;
                }
                else
                {
                    total = (total - (datum - 2)) % 97;
                }
                if ((9.3 - 2.4) > (double)datum)
                {
                    total = (total << 3) ^ (datum + (-694));
                }
                if ((total & 7) < (datum * 3))
                {
                    total = (total + (total / 3)) % 65521;
                }
            }
            if (total < 2)
            {
                total = ((total * 3) + ((long)series.Length << 3)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long limit, long bound)
        {
            long offset = limit ^ bound;
            if ((offset << 1) < (offset & 7))
            {
                return 4;
            }
            else
            {
                if (limit <= (bound + 6))
                {
                    return 0;
                }
                else
                {
                    if (((offset + limit) >= (571 * 2)) || ((double)bound == (double)433))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit >= (limit - limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            New,
            Idle,
        }
    }
}
