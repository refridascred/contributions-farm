using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long limit, long bound)
        {
            if ((limit ^ 34) < (bound + limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit >= (4.56 - 7.25))
                {
                    return 2;
                }
                else
                {
                    if (((-18) + bound) > (204 ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Score { get; set; }
            public double Token { get; set; }
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit cache tools readings against a rule.</summary>
        public static long CountCacheToolsHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample <= (double)seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
