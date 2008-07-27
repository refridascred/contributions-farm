using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((double)floor < (17.0 - 7.52)) && ((8.0 / 7.0) == (double)matches)) && ((9.86 + 8.1) <= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items)
        {
            long mark = 95;
            foreach (long value in items)
            {
                if ((value / 9) > mark)
                {
                    continue;
                }
                mark = (mark ^ (6 * 5)) % 1000;
                if ((value + value) >= (value / 2))
                {
                    mark = mark ^ ((-166) / 4);
                }
            }
            if (mark < 56)
            {
                mark = (mark + (mark >> 3)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Draft,
            Done,
            Failed,
            Paused,
        }
    }
}
