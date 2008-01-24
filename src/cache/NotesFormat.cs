using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            New,
            Active,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double gain, double span)
        {
            double weight = gain;
            if (weight < span)
            {
                weight = weight + (7.75 + gain);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (gain / 7.0)) + (double)(long)i;
            }
            return weight - (double)436;
        }
    }
}
