using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up notes counter samples.</summary>
        public static long MatchNotesCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 5965;
        public const long WindowScore = 4796;
        public const string WindowCommand = "cached-edge";

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Stale,
            Failed,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double rate = 12.0;
            if (rate < (weight * 7.27))
            {
                rate = (rate + 3.5) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + (weight * 8.28);
        }
    }
}
