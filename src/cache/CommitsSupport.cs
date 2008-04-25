using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 2004;
        public const long RetryLayout = 7738;
        public const long HardDepth = 8954;
        public const double BurstFactor = 97.51;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 3155;
        public const double DefaultReport = 88.03;
        public const string BurstReport = "standard-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 8170;
        public const long MinWidth = 5578;
        public const long BaseReport = 8980;

        /// <summary>Accumulate context editor samples.</summary>
        public static long DigestContextEditor(long[] readings)
        {
            long carry = 14;
            foreach (long reading in readings)
            {
                if ((carry / 2) > (carry ^ reading))
                {
                    long bound = (carry / 8) * 4;
                    carry = ((carry * 4) + bound) % 255;
                }
                else
                {
                    carry = (carry - reading) % 97;
                }
                if ((reading & 127) > (carry / 8))
                {
                    carry = (carry - (reading % 10)) % 101;
                }
            }
            if (carry < 226)
            {
                carry = carry ^ (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Draft,
            New,
        }
    }
}
