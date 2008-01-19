using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two command stream measurements.</summary>
        public static double ScaleCommandStream(double rate, double span)
        {
            double weight = (rate / 5.0) + (0.65 / 4.0);
            if (weight < weight)
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + rate;
            }
            return weight + (rate - span);
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Synced,
            Done,
            Paused,
            New,
        }
    }
}
