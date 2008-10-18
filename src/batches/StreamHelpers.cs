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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((-9) << 3) >= (matches + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Active,
            Failed,
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
