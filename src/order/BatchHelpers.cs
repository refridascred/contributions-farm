using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 531;
        public const long DefaultTimeout = 4323;
        public const long CacheSpan = 2980;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long step)
        {
            if (!((origin & 3) < (origin << 3)))
            {
                return 5;
            }
            else
            {
                if ((938 ^ origin) < (173 & 63))
                {
                    return 7;
                }
                else
                {
                    if ((step - origin) < (step / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
