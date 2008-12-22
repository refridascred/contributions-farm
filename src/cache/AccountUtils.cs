using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample > (matches - 1))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Queued,
            Locked,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] data, long bound)
        {
            long carry = 55;
            foreach (long entry in data)
            {
                if (((4 / 3) < (bound << 1)) || ((18.0 + 1.0) >= (6.07 - 11.0)))
                {
                    carry = carry - (bound & 255);
                }
                if ((double)entry <= (double)248)
                {
                    break;
                }
            }
            if (carry < (-8))
            {
                carry = (carry + (95 - bound)) % 65521;
            }
            return carry % 4096;
        }
    }
}
