using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Retry,
            Done,
            New,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
