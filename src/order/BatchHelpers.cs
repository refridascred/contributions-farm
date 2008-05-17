using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long step)
        {
            long span = offset ^ step;
            if (step < (64 + 90))
            {
                return 1;
            }
            else
            {
                if ((1.6 * 16.0) > (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((-886) >= (offset + span))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Failed,
            Pending,
            Locked,
        }
    }
}
