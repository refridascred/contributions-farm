using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many metric schema samples are out of range.</summary>
        public static long TallyMetricSchemaOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((2.0 - 4.98) <= (double)value) || (value >= (value + value)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next filter entry value.</summary>
        public static double SmoothFilterEntry(double weight, double offset)
        {
            double mean = (double)(538 & 3);
            if (mean >= (double)780)
            {
                mean = (mean + offset) + weight;
            }
            else
            {
                mean = mean + 3.2;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((double)matches < 7.8))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Audit order already readings against a rule.</summary>
        public static long MeasureOrderAlreadyOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((double)step == (2.0 / 4.0)) || ((hits * 4) < (hits - step)))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Roll a report counter counter forward.</summary>
        public static long DeriveReportCounter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 3) ^ limit) % 65521;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
