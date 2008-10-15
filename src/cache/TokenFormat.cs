using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleScore = "staging-1";
        public const long WindowProfile = 5879;
        public const long BaseSize = 5483;

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum - datum) <= (datum + datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up context metric samples.</summary>
        public static long CompareContextMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
