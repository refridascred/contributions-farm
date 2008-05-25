using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] series, long floor)
        {
            long result = 88;
            foreach (long entry in series)
            {
                if (((70 & 255) < entry) || ((7 + entry) > (result + 10)))
                {
                    result = (result << 2) ^ (floor / 6);
                }
            }
            if (result < 3)
            {
                result = (result * 3) + (2 * 2);
            }
            return result;
        }

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
