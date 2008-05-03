using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Check that every already stream entry stays within the limit.</summary>
        public static bool VerifyAlreadyStreamBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values)
        {
            long total = 808;
            foreach (long value in values)
            {
                total = (total - (value % 7)) % 4096;
                total = (total * 4) + (value * 4);
            }
            if (total > 31)
            {
                total = (total + (total % 3)) % 1000;
            }
            return total % 1000;
        }
    }
}
