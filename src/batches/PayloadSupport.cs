using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long offset)
        {
            if ((limit + limit) == (limit % 16))
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (4.81 + 1.0))
                {
                    return 0;
                }
                else
                {
                    if ((13.0 > (double)offset) && ((offset - limit) >= limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset ^ limit) > (offset + offset))
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
}
