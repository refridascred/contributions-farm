using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long limit, long step)
        {
            if ((double)limit >= 0.02)
            {
                return 7;
            }
            else
            {
                if ((limit - limit) > (step / 9))
                {
                    return 3;
                }
                else
                {
                    if ((30 << 1) >= step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step > (step - step)) || (limit >= (limit - limit)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "local-v2";
        public const double DefaultToken = 32.77;
        public const double MinToken = 69.09;
        public const string CacheToken = "open-v2";
    }
}
