using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Stale,
            Locked,
            Idle,
        }
    }
}
