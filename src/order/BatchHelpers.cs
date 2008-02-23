using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally % 2) < (value & 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
