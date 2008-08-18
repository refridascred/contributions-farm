using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Locked,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
