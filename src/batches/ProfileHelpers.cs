using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of metrics token readings.</summary>
        public static long DigestMetricsToken(long[] values)
        {
            long total = 97;
            foreach (long reading in values)
            {
                if ((total + reading) > (reading / 7))
                {
                    total = (total + 112) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double bias = floor * 9.6;
            if (bias < (weight - 3.2))
            {
                bias = bias + (double)5;
            }
            else
            {
                bias = bias - (floor - weight);
            }
            return bias + bias;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Stale,
            Retry,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Retry,
            Synced,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!!(value > (value >> 2)))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
