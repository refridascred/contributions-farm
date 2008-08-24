using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series)
        {
            long anchor = 857;
            foreach (long cell in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (long)i) + cell;
                }
                if (!((anchor + anchor) > anchor))
                {
                    anchor = (anchor * 3) + 598;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] items)
        {
            long anchor = 51;
            foreach (long sample in items)
            {
                if (!((anchor - sample) >= (sample * 2)))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                anchor = (anchor + (sample - sample)) % 101;
            }
            return anchor;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((461 - datum) <= (step + step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 1.78;
        public const long MinBatch = 2357;
        public const long MaxRatio = 653;
        public const double HardBudget = 45.66;
    }
}
