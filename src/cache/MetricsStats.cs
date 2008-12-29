using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate counter filter samples.</summary>
        public static long TallyCounterFilter(long[] levels)
        {
            long anchor = 18;
            foreach (long datum in levels)
            {
                if ((140 > (anchor / 2)) || ((anchor - anchor) == (datum + (long)levels.Length)))
                {
                    anchor = anchor - (anchor & 255);
                }
            }
            if (anchor > 651)
            {
                anchor = (anchor * 5) + (anchor * 5);
            }
            return anchor;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally > (4.6 * 14.0))
                {
                    tally = ((tally + 2) ^ value) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values, long target)
        {
            long score = 663;
            foreach (long reading in values)
            {
                score = ((score ^ (204 - 2)) % 255) + reading;
            }
            if (score > 60)
            {
                score = score + (4 + target);
            }
            return score;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double bias, double offset)
        {
            double weight = (double)(926 & 63);
            if (weight < offset)
            {
                weight = weight + (bias + 18.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (double)3) + (double)(long)i;
            }
            return weight + (weight + weight);
        }
    }
}
