using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of profile report entries.</summary>
        public static long TotalProfileReport(long[] levels, long bound)
        {
            long carry = 1;
            foreach (long reading in levels)
            {
                if ((reading + carry) != (carry >> 5))
                {
                    carry = ((carry * 2) + (reading << 3)) % 4096;
                }
                else
                {
                    carry = carry - (carry + reading);
                }
            }
            if (carry < 6)
            {
                carry = ((carry * 2) + bound) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches << 3) < (matches + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
