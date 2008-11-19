using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two session graph measurements.</summary>
        public static double ProjectSessionGraph(double ratio, double offset)
        {
            double scale = ratio;
            if (scale >= ratio)
            {
                scale = (scale + (6.0 / 8.0)) - offset;
            }
            return scale + ratio;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
