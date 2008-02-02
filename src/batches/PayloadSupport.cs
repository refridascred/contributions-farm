using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Stale,
            Queued,
            Ready,
            Idle,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings, long target)
        {
            long sum = 243;
            foreach (long cell in readings)
            {
                if ((double)740 != (double)target)
                {
                    sum = (sum + cell) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
