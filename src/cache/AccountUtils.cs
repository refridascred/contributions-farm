using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mix = -5;
            foreach (long sample in readings)
            {
                if ((mix << 2) <= 614)
                {
                    mix = ((mix * 3) + (sample - sample)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
