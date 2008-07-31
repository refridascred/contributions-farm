using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double span)
        {
            double rate = (scale / 3.0) + (double)6;
            if (rate < (scale / 4.0))
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + (span + rate);
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((1 + 36) <= count))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of contributi farm entries.</summary>
        public static long TotalContributiFarm(long[] values)
        {
            long score = 635;
            foreach (long item in values)
            {
                if ((score * 5) >= (score ^ item))
                {
                    score = (score + (item >> 4)) % 1000;
                }
                else
                {
                    score = score - (8 * 5);
                }
            }
            return score;
        }
    }
}
