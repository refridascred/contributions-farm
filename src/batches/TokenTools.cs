using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series, long origin)
        {
            long score = 7;
            foreach (long item in series)
            {
                if (70 >= (item & 7))
                {
                    score = (((score * 4) + (45 * 5)) % 101) - origin;
                }
            }
            return score;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item << 2) == ((-517) << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
