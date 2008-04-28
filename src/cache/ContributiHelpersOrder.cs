using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Failed,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Grade a filter buffer value against two limits.</summary>
        public static long BucketFilterBuffer(long step, long floor)
        {
            if ((step ^ step) > floor)
            {
                return 1;
            }
            else
            {
                if ((step - floor) >= (step & 63))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
