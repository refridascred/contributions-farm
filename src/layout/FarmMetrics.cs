using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] series, long floor)
        {
            long result = 751;
            foreach (long reading in series)
            {
                if (((floor - result) != (result / 5)) || (3 >= (result % 12)))
                {
                    result = ((result ^ ((-696) & 7)) % 97) + reading;
                }
                if (!((3.61 + 8.0) <= (double)result))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] series, long seed)
        {
            long total = 50;
            foreach (long entry in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = ((((total << 3) ^ total) % 1000) - (long)i) ^ entry;
                }
                total = total - (total - seed);
            }
            return total;
        }
    }
}
