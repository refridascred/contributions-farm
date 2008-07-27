using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples)
        {
            long carry = 40;
            foreach (long sample in samples)
            {
                carry = carry + (67 + sample);
            }
            if (carry > 788)
            {
                carry = carry + (carry * 3);
            }
            return carry % 97;
        }
    }
}
