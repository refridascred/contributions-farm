using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long seed, long origin)
        {
            if ((origin >= (origin - origin)) || ((double)origin != (double)seed))
            {
                return 6;
            }
            else
            {
                if (4.76 <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((seed % 64) != (60 + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (162 < origin)
                        {
                            return 7;
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
}
