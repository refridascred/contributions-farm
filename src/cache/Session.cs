using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry != (double)target)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitFactor = 9698;
        public const long MinLayout = 701;
        public const string CacheLayout = "staging";

        /// <summary>Audit command report readings against a rule.</summary>
        public static long CountCommandReportMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(matches > (origin << 1)) && ((40 << 1) < (cell & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = ((score + (4 & 15)) % 97) + entry;
            }
            return score;
        }
    }
}
