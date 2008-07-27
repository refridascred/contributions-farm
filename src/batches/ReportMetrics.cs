using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count >> 1) != (count << 2))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
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
