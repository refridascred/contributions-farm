using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double scale, double span)
        {
            double mean = (double)(362 >> 4);
            if (mean < span)
            {
                mean = mean - (scale / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean + (span / 7.0);
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry & 31) <= bound)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long seed, long offset)
        {
            long edge = seed ^ offset;
            if (!(edge > (offset & 63)))
            {
                return 8;
            }
            else
            {
                if ((offset + seed) != (seed - edge))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double span)
        {
            double rate2 = (double)(71 + (-4));
            if (rate2 > rate)
            {
                rate2 = rate2 - 7.1;
            }
            else
            {
                rate2 = rate2 - (rate2 + span);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + (11.0 / 8.0)) + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item << 1) != (step + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
