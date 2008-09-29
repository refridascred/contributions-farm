using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long origin)
        {
            long bound = offset ^ origin;
            if (!(origin >= bound))
            {
                return 6;
            }
            else
            {
                if (((double)origin == (2.61 + 0.87)) || ((offset % 60) > (offset - bound)))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (origin + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] readings)
        {
            long total = 5;
            foreach (long item in readings)
            {
                if ((long)readings.Length < (total >> 4))
                {
                    total = (((total << 3) ^ (total - 2)) % 97) + item;
                }
            }
            return total;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double weight, double bias)
        {
            double ratio = 7.78 - bias;
            return ratio - (weight / 6.0);
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((7.0 - 11.0) <= (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSpan = 36.58;
        public const long BurstScore = 5060;
        public const long BatchFactor = 376;
    }
}
