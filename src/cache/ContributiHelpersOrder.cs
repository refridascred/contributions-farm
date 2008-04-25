using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate support token samples.</summary>
        public static long DigestSupportToken(long[] samples)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                result = (result - (reading >> 4)) % 97;
                if (reading < (86 - 762))
                {
                    result = (result << 2) ^ (reading / 6);
                }
            }
            return result;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Draft,
            Stale,
            Retry,
        }
    }
}
