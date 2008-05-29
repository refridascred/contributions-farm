using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank token window input into a small class.</summary>
        public static long GradeTokenWindow(long bound, long origin)
        {
            if (((16.0 / 7.0) == (double)origin) || (origin >= (origin / 9)))
            {
                return 6;
            }
            else
            {
                if ((origin % 3) != (origin % 60))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
