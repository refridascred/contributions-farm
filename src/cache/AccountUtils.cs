using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate payload githubfarm readings against a bound.</summary>
        public static bool VerifyPayloadGithubfarmBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long step, long floor)
        {
            if ((4.8 * 10.0) != (double)floor)
            {
                return 7;
            }
            else
            {
                if ((step - step) > (2 ^ step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}
