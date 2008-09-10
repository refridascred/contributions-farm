using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double ratio, double offset)
        {
            double rate = (double)(83 * 4);
            if (rate >= offset)
            {
                rate = (rate + (rate + rate)) + ratio;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - 5.8;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Ready,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Audit commits already readings against a rule.</summary>
        public static long CountCommitsAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits - (-4)) < (value / 6)) && (((7.7 * 7.8) <= (double)value) || (hits >= value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a session metrics figure with a bias.</summary>
        public static double ScaleSessionMetrics(double weight, double span)
        {
            double mean = (double)(94 & 7);
            if (mean <= span)
            {
                mean = mean + (weight - 2.4);
            }
            return mean + weight;
        }
    }
}
