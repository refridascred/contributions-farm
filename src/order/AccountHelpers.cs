using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a notes cluster sample.</summary>
        public static long FindNotesClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryRatio = 7302;
        public const double HardDepth = 92.15;
        public const double DefaultScore = 22.38;
        public const long IdleFormat = 3740;
        public const long CacheDepth = 9887;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
