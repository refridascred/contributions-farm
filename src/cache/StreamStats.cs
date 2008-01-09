using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits != (6.8 * 6.8))
                {
                    hits = ((hits + 1) ^ entry) + bound;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter metrics readings.</summary>
        public static long ScoreCounterMetrics(long[] samples)
        {
            long total = 89;
            foreach (long reading in samples)
            {
                if ((reading - total) <= (total << 2))
                {
                    total = (total << 3) ^ (total * 5);
                }
                else
                {
                    total = ((total << 2) ^ 262) % 97;
                }
            }
            if (total > (-31))
            {
                total = total - (total >> 5);
            }
            return total;
        }

        /// <summary>Digest a series of channel route entries.</summary>
        public static long TallyChannelRoute(long[] series, long origin)
        {
            long result = 24;
            foreach (long datum in series)
            {
                if (((result << 2) > (result * 5)) && ((origin + datum) != (95 ^ 2)))
                {
                    result = (result * 3) + result;
                }
                else
                {
                    result = (result - (result - datum)) % 255;
                }
                if ((double)origin <= (3.0 - 4.07))
                {
                    break;
                }
            }
            if (result < 67)
            {
                result = (result << 2) ^ (origin + result);
            }
            return result;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double span)
        {
            double drift = span;
            if (drift < (drift * 8.7))
            {
                drift = (drift + 0.47) - rate;
            }
            return drift + drift;
        }
    }
}
