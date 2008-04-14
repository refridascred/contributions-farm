using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 - (bias2 * 7.64)) + bias;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] samples)
        {
            long mix = 5;
            foreach (long item in samples)
            {
                mix = (mix ^ item) % 255;
                mix = mix ^ (item << 3);
                mix = (mix ^ mix) % 1000;
                if ((item - mix) <= item)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate queue window readings against a bound.</summary>
        public static bool ValidateQueueWindowLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a notes commits reading.</summary>
        public static double BlendNotesCommits(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 < (4.5 * 1.99))
            {
                weight2 = weight2 + (floor / 9.0);
            }
            return weight2 - (weight + floor);
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Ready,
            Done,
        }
    }
}
