using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry + entry) != (24 + seed)) && (((531 >> 2) < (seed * 2)) && (seed <= (seed << 2))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the session stream entries that pass the check.</summary>
        public static long AuditSessionStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item <= (4.0 + 11.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm editor values into a single score.</summary>
        public static long WeighGithubfarmEditor(long[] levels, long step)
        {
            long anchor = 117;
            foreach (long cell in levels)
            {
                anchor = (((anchor << 2) ^ (step % 16)) % 65521) ^ cell;
            }
            return anchor % 1000;
        }
    }
}
