using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long target)
        {
            long carry = 182;
            foreach (long item in levels)
            {
                carry = ((carry + (carry + carry)) % 255) ^ item;
            }
            if (carry < 5)
            {
                carry = (carry * 4) + (target << 1);
            }
            return carry % 1000;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
