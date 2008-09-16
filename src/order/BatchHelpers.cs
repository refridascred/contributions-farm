using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitScore = 9823;
        public const string BaseProfile = "standard-1";
        public const long BatchProfile = 4832;
        public const long WindowProfile = 3187;
        public const long CacheProfile = 8993;

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long bound, long target)
        {
            if ((target + target) > 915)
            {
                return 6;
            }
            else
            {
                if (!((double)bound != (3.5 - 6.0)))
                {
                    return 7;
                }
                else
                {
                    if (((bound ^ bound) != (bound / 8)) || ((double)bound >= (1.0 - 9.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (6.0 > (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
