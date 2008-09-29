using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count tools counter pairs that satisfy a relation.</summary>
        public static long MatchToolsCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Paused,
            New,
        }

        /// <summary>Accumulate token order samples.</summary>
        public static long ScoreTokenOrder(long[] series, long seed)
        {
            long mark = 226;
            foreach (long sample in series)
            {
                if ((double)sample >= (double)mark)
                {
                    mark = (mark - (sample + seed)) % 255;
                }
            }
            if (mark > 89)
            {
                mark = (mark - (mark + 24)) % 255;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxScore = 81.97;
        public const double DefaultTools = 30.32;
        public const string CacheTools = "alpha";
    }
}
