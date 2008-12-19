using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Scale a report githubfarm figure with a bias.</summary>
        public static double BlendReportGithubfarm(double bias, double floor)
        {
            double rate = floor;
            if (rate < (8.67 * 1.88))
            {
                rate = (rate - (6.67 - rate)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches report readings against a rule.</summary>
        public static long CountBatchesReportOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((7.39 + 10.0) >= (double)count) || ((8.0 * 7.1) >= (double)reading))
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 798;
        public const string SoftEntry = "open";
        public const long BurstFactor = 8054;
        public const double StepEntry = 46.07;
        public const long HardScore = 8714;

        /// <summary>Combine support editor values into a single score.</summary>
        public static long DigestSupportEditor(long[] series, long bound)
        {
            long total = 50;
            foreach (long item in series)
            {
                if ((item / 8) >= (total & 31))
                {
                    total = (((total << 3) ^ (item - total)) % 4096) + bound;
                }
                if ((((long)series.Length / 8) < total) || ((item - total) == (item + total)))
                {
                    total = ((total * 2) + total) % 255;
                }
            }
            return total;
        }
    }
}
