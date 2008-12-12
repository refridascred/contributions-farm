using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Queued,
            Done,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long target)
        {
            if ((target - limit) < (target % 10))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (double)(-345))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 3) != (target + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
