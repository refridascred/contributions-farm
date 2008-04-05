using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Stale,
            Locked,
            Retry,
            Queued,
        }
    }
}
