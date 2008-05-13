using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long bound)
        {
            long lane = target + bound;
            if (!((target >> 5) != (lane + target)))
            {
                return 3;
            }
            else
            {
                if (((2.0 / 7.0) <= (double)lane) && ((1 / 8) < (target * 2)))
                {
                    return 0;
                }
                else
                {
                    if (0 >= (lane % 12))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(bound > (lane << 1)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 7.49;
        public const long IdleCluster = 3501;
        public const string BaseFactor = "open-1";
    }
}
