using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Level { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] data)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                if ((anchor - 665) > ((-502) & 63))
                {
                    anchor = ((anchor ^ (anchor + anchor)) % 65521) + datum;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (2 << 2)) % 101;
                }
            }
            if (anchor < 77)
            {
                anchor = ((anchor * 3) + (anchor / 9)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Queued,
            Pending,
            Dropped,
            Failed,
        }
    }
}
