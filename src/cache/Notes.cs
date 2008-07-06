using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a session metric sample.</summary>
        public static long FindSessionMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Idle,
            New,
            Done,
            Closed,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
