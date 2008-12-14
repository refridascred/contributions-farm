using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Dropped,
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first token already entry that matches the target.</summary>
        public static long LocateTokenAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
