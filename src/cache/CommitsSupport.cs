using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Queued,
            Active,
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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] series, long step)
        {
            long result = 29;
            foreach (long datum in series)
            {
                result = ((result ^ (45 - result)) - datum) + step;
            }
            if (result < 4)
            {
                result = result - (result ^ result);
            }
            return result;
        }

        /// <summary>Scale a support token figure with a bias.</summary>
        public static double AdjustSupportToken(double ratio, double bias)
        {
            double mean = bias;
            return (mean + bias) + ratio;
        }
    }
}
