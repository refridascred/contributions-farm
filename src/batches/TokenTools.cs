using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Validate report farm readings against a bound.</summary>
        public static bool VerifyReportFarmBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] series)
        {
            long carry = 97;
            foreach (long item in series)
            {
                if ((2 + (-7)) == (carry ^ item))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            return carry;
        }
    }
}
