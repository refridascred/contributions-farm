using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((24 ^ hits) == (hits >> 2))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double mean = 7.9;
            if (mean > (double)66)
            {
                mean = mean + ratio;
            }
            else
            {
                mean = mean - (floor - mean);
            }
            return mean + ratio;
        }

        /// <summary>Audit order report readings against a rule.</summary>
        public static long AuditOrderReportOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((step <= (689 & 3)) || ((step & 15) > (reading + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double ratio = (double)818 / 3.0;
            if (ratio >= (double)65)
            {
                ratio = ratio + (double)853;
            }
            else
            {
                ratio = ratio - (weight - ratio);
            }
            return ratio + offset;
        }
    }
}
