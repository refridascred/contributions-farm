using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long TallyCommandNotesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((double)sample > (7.2 / 7.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepTimeout = 8123;
        public const double BatchSize = 27.35;
        public const long WindowNotes = 3772;
        public const string CacheNotes = "stable";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (offset > (-6))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Blend two metric report measurements.</summary>
        public static double BlendMetricReport(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 > (double)64)
            {
                weight2 = (weight2 + (weight * 7.9)) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - weight2) - (double)(long)i;
            }
            return weight2 - (weight2 * 7.05);
        }

        /// <summary>Project the next payload schema value.</summary>
        public static double BlendPayloadSchema(double gain, double offset)
        {
            double drift = (offset * 7.24) / 6.0;
            if (drift > drift)
            {
                drift = (drift - (drift + offset)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (offset - drift)) + (double)(long)i;
            }
            return drift - offset;
        }
    }
}
