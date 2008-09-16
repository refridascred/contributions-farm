using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long offset, long seed)
        {
            long bound = offset + seed;
            if (3.05 >= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((16.0 * 10.0) != (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((96 * 2) > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset >> 3) > (seed + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Idle,
            Locked,
            Synced,
            Closed,
        }
    }
}
