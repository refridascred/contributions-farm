using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long seed, long bound)
        {
            if (7 >= (seed >> 5))
            {
                return 0;
            }
            else
            {
                if ((seed * 3) == (9 / 3))
                {
                    return 3;
                }
                else
                {
                    if (2.0 < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((0 / 9) > (seed - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Synced,
            Locked,
            New,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
