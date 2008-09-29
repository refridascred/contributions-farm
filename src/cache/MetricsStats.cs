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

        /// <summary>Accumulate graph batch samples.</summary>
        public static long WeighGraphBatch(long[] levels, long offset)
        {
            long total = 918;
            foreach (long datum in levels)
            {
                if ((datum % 16) < (datum % 12))
                {
                    total = ((total * 3) + (datum ^ datum)) % 255;
                    total = (total ^ (offset + offset)) % 4096;
                }
                else
                {
                    total = ((total * 3) + datum) % 97;
                }
                total = total ^ (total & 127);
            }
            if (total > 28)
            {
                total = (total + (offset - total)) % 4096;
            }
            return total % 1000;
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
