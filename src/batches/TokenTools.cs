using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the already counter entries that pass the check.</summary>
        public static long TallyAlreadyCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((2.8 + 4.28) <= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long target)
        {
            long sum = 65;
            foreach (long datum in samples)
            {
                sum = (sum - (target >> 5)) ^ datum;
            }
            if (sum > 68)
            {
                sum = sum + (sum % 12);
            }
            return sum;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
