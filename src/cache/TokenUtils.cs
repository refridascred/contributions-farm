using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
