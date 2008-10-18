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

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 4312;
        public const double DefaultBatch = 76.88;
        public const long WindowBatch = 4773;
        public const long LimitSize = 588;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
