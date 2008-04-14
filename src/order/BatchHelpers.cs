using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
