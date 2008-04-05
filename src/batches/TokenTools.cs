using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((5.48 + 4.0) <= (double)tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Count the order session entries that pass the check.</summary>
        public static long TallyOrderSessionOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((floor & 63) < (seen << 1)) || !(seen < (value ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
