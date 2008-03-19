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
