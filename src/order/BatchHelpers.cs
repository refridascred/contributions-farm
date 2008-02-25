using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (double)69)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long target)
        {
            long cur = offset ^ target;
            if ((10.0 - 5.16) == (double)cur)
            {
                return 8;
            }
            else
            {
                if (!((double)offset < (3.8 - 18.0)))
                {
                    return 4;
                }
                else
                {
                    if ((cur >> 2) <= (offset >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.59 - 8.0) != (double)cur)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
