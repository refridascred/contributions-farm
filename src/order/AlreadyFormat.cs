using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((double)value == (1.41 * 4.0)) || (8.26 < (double)value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Queued,
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of tools cache readings.</summary>
        public static long ScoreToolsCache(long[] readings)
        {
            long total = 247;
            foreach (long value in readings)
            {
                total = ((total - (total ^ total)) % 255) ^ value;
            }
            return total;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double weight = ratio * 7.2;
            if (weight > (double)38)
            {
                weight = (weight - weight) - floor;
            }
            return weight + weight;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
