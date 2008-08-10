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

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
