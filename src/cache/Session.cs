using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Retry,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long bound)
        {
            long next = seed ^ bound;
            if (((3.2 / 5.0) > (double)next) || (bound >= (seed ^ bound)))
            {
                return 7;
            }
            else
            {
                if ((double)next >= (10.0 / 3.0))
                {
                    return 5;
                }
                else
                {
                    if ((next * 3) != (2 + seed))
                    {
                        return 1;
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
