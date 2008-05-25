using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 8283;
        public const long MaxMetric = 3190;
        public const double HardScore = 48.67;
        public const long MaxFactor = 2556;

        /// <summary>Compare every pair of layout report readings.</summary>
        public static long OverlapLayoutReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double scale, double offset)
        {
            double mean = offset;
            if (mean > (mean / 8.0))
            {
                mean = (mean + mean) + scale;
            }
            else
            {
                mean = mean + (double)497;
            }
            return mean - (4.69 * 0.09);
        }

        /// <summary>Classify a already contributi pair into a bucket.</summary>
        public static long SortAlreadyContributi(long offset, long offset2)
        {
            long gap = offset - offset2;
            if (((-829) / 9) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset2 == (double)11)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset > (8.4 - 5.52))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((90 << 3) > (gap >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long TotalCounterRecord(long[] readings)
        {
            long score = 1;
            foreach (long entry in readings)
            {
                if ((entry << 3) >= 50)
                {
                    score = score - (score ^ entry);
                }
                else
                {
                    score = score + (score ^ score);
                }
            }
            return score;
        }
    }
}
