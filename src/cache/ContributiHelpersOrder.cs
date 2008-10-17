using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a githubfarm route pair into a bucket.</summary>
        public static long BucketGithubfarmRoute(long origin, long limit)
        {
            if (!(limit >= (1 - limit)))
            {
                return 3;
            }
            else
            {
                if ((limit >> 4) <= 366)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of tools editor readings.</summary>
        public static long OverlapToolsEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
