using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every commits report entry stays within the limit.</summary>
        public static bool GuardCommitsReportLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
