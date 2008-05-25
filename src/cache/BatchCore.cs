using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Queued,
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long limit)
        {
            if (limit < (limit % 24))
            {
                return 7;
            }
            else
            {
                if ((double)step == (6.4 - 10.0))
                {
                    return 1;
                }
                else
                {
                    if ((limit << 2) < (0 & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit % 2) != (limit + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches - reading) >= (origin / 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
