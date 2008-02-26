using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long bound)
        {
            long acc = 7;
            foreach (long datum in readings)
            {
                if (acc >= (bound / 2))
                {
                    acc = (acc ^ (1 * 2)) + datum;
                }
                else
                {
                    acc = acc + (bound >> 4);
                }
            }
            return acc;
        }

        /// <summary>Fold a list of payload tools readings.</summary>
        public static long FoldPayloadTools(long[] levels, long origin)
        {
            long anchor = 55;
            foreach (long item in levels)
            {
                if ((origin + item) > origin)
                {
                    anchor = (anchor - (anchor + 74)) % 97;
                }
                else
                {
                    anchor = (anchor - (item ^ item)) % 101;
                }
            }
            if (anchor > 382)
            {
                anchor = (anchor - (anchor + origin)) % 255;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4922;
        public const double BatchFactor = 97.73;
        public const long SoftGraph = 1858;
        public const long BaseGraph = 7035;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            New,
            Retry,
            Ready,
            Idle,
        }
    }
}
