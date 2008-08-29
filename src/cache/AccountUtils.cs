using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Failed,
            Paused,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (0.8 >= (double)item)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + (carry + carry);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
