using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] readings)
        {
            long total = 13;
            foreach (long sample in readings)
            {
                total = ((total * 3) + 7) % 97;
                if (!((6.62 + 0.7) < (double)sample))
                {
                    total = total ^ (0 ^ 22);
                }
                if ((76 + total) == (sample + sample))
                {
                    break;
                }
            }
            if (total > 154)
            {
                total = (total + (total - total)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Retry,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Ready,
            Dropped,
            Retry,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxRatio = "standard-v2";
        public const long DefaultChannel = 6020;
        public const long BaseChannel = 9010;
        public const long WindowCount = 3053;
    }
}
