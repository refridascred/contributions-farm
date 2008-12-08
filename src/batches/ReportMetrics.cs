using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Stale,
            Locked,
            Failed,
            New,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] samples, long offset)
        {
            long carry = 78;
            foreach (long cell in samples)
            {
                if ((321 + cell) == (36 + 6))
                {
                    carry = (carry << 2) ^ ((long)samples.Length - offset);
                    carry = carry + (cell ^ offset);
                }
                carry = (carry << 3) ^ (cell & 1);
                carry = (carry - ((-94) + cell)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Failed,
            Locked,
        }
    }
}
