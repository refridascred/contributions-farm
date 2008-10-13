using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix - (mix + mix)) % 1000;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Draft,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Dropped,
            New,
            Idle,
            Active,
        }
    }
}
