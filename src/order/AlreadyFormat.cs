using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long bound, long origin)
        {
            if ((origin * 3) <= (bound + bound))
            {
                return 7;
            }
            else
            {
                if (((origin * 4) < (origin & 127)) && (bound < (origin / 7)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long step, long step2)
        {
            if ((double)step2 < (19.0 * 15.0))
            {
                return 1;
            }
            else
            {
                if ((step << 1) <= ((-982) + 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double mean = 2.1 * 1.6;
            if (mean >= (floor * 13.0))
            {
                mean = (mean - mean) + rate;
            }
            else
            {
                mean = mean - (mean - floor);
            }
            return mean - mean;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((582 << 3) < (item << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
