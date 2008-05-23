using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((-55) - count) > count)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items)
        {
            long score = -95;
            foreach (long value in items)
            {
                if ((double)score < (8.35 + 8.72))
                {
                    score = ((score - score) % 97) ^ value;
                }
                else
                {
                    score = (score ^ 409) % 65521;
                }
            }
            if (score < 879)
            {
                score = score - (758 * 4);
            }
            return score % 97;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double weight, double bias)
        {
            double gain = 19.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (weight - weight);
        }

        /// <summary>Scale a support token figure with a bias.</summary>
        public static double AdjustSupportToken(double ratio, double bias)
        {
            double mean = bias;
            return (mean + bias) + ratio;
        }
    }
}
