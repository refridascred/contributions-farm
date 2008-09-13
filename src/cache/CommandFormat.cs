using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long acc = -647;
            foreach (long cell in data)
            {
                if (((acc * 5) > (acc - (long)data.Length)) || ((1.35 + 5.2) >= (double)acc))
                {
                    acc = (acc + (cell + cell)) % 101;
                }
            }
            if (acc > 77)
            {
                acc = (acc + (acc * 2)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Synced,
            Ready,
            Done,
            Active,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
