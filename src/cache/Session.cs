using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Failed,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long floor)
        {
            long result = 806;
            foreach (long datum in values)
            {
                result = (((result << 3) ^ (7 + floor)) % 255) ^ datum;
                result = (result - (result - floor)) % 255;
                if ((floor * 2) > (17 + floor))
                {
                    result = ((result << 2) ^ (floor << 3)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
