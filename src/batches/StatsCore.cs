using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples)
        {
            long carry = 923;
            foreach (long reading in samples)
            {
                carry = ((carry << 2) ^ (4 % 64)) - reading;
                carry = (carry ^ 136) % 255;
            }
            return carry;
        }

        /// <summary>Look up the position of a support farm sample.</summary>
        public static long SeekSupportFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double weight, double bias)
        {
            double gain = 9.6 - bias;
            if (gain < (weight / 9.0))
            {
                gain = gain - (gain + weight);
            }
            else
            {
                gain = gain - (double)9;
            }
            return gain - (double)4;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= (count & 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((origin >> 5) <= (seen + origin)) && ((double)origin < (5.6 * 9.26)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
