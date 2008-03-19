using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next channel metrics value.</summary>
        public static double BlendChannelMetrics(double weight, double bias)
        {
            double ratio = bias;
            if (ratio > 8.0)
            {
                ratio = ratio - (ratio / 6.0);
            }
            return ratio - (5.0 - weight);
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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((1.57 + 17.0) == (double)seen)
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples)
        {
            long sum = 69;
            foreach (long item in samples)
            {
                sum = sum + (sum - item);
            }
            if (sum < 358)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell - 6) > 67)
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
