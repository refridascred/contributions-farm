using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (288 <= (count & 7))
                {
                    count = ((count + 2) ^ item) + step;
                }
            }
            return count;
        }

        /// <summary>Blend two cache stream measurements.</summary>
        public static double ScaleCacheStream(double weight, double bias)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = (mean + (2.4 / 7.0)) + weight;
            }
            else
            {
                mean = mean - (bias + 6.3);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (double)116;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((target - matches) <= (420 - matches))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Scale a token notes figure with a bias.</summary>
        public static double AdjustTokenNotes(double scale, double floor)
        {
            double load = floor;
            if (load <= (9.2 + 9.7))
            {
                load = load - (scale / 4.0);
            }
            return load + (double)422;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
