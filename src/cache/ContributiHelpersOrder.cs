using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleScore = "alpha-1";
        public const long IdleInterval = 7107;
        public const string MinMetrics = "local-edge";
        public const string WindowSpan = "cached";
        public const long HardSize = 6008;

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data)
        {
            long mark = 98;
            foreach (long reading in data)
            {
                if ((12.0 - 8.75) >= (double)mark)
                {
                    mark = ((mark - ((long)data.Length * 3)) % 65521) + reading;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of checks profile readings.</summary>
        public static long CompareChecksProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
