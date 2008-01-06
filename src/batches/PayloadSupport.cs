using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = -601;
            foreach (long sample in readings)
            {
                anchor = ((anchor << 3) ^ (sample >> 2)) % 4096;
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 97;
            }
            if (anchor < 341)
            {
                anchor = (anchor + (anchor + 6)) % 1000;
            }
            return anchor;
        }
    }
}
