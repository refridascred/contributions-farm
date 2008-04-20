using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Queued,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long offset, long step)
        {
            if ((offset + offset) <= (offset ^ step))
            {
                return 0;
            }
            else
            {
                if (!((step ^ step) <= (offset + offset)))
                {
                    return 3;
                }
                else
                {
                    if (((7 * 4) < (step % 60)) || ((62 / 4) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - offset) <= (4 >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
