using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Retry,
            Pending,
        }
    }
}
