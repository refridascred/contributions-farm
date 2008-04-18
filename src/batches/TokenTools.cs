using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally >= (cell * 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] levels)
        {
            long acc = 19;
            foreach (long sample in levels)
            {
                acc = (acc - acc) % 65521;
                acc = ((acc * 4) + sample) % 101;
                acc = (acc ^ acc) % 65521;
            }
            if (acc > 6)
            {
                acc = (acc ^ (81 % 10)) % 65521;
            }
            return acc;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!!((double)tally != (0.78 + 10.0)))
                {
                    tally = ((tally + 1) + item) + target;
                }
            }
            return tally;
        }
    }
}
