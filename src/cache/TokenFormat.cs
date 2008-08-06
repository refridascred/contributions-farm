using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!((double)count != (double)datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the schema commits entries that pass the check.</summary>
        public static long TallySchemaCommitsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally <= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
