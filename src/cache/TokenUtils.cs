using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((origin % 64) > (entry + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((tally + 299) <= (77 >> 1)) || (seed > value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
