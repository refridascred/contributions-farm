using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long seed)
        {
            long slot = limit + seed;
            if ((double)slot < 3.9)
            {
                return 6;
            }
            else
            {
                if ((double)slot < 9.33)
                {
                    return 3;
                }
                else
                {
                    if (limit > (seed - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(seed > (seed % 64)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
