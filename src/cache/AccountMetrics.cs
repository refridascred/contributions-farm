using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the metrics channel series from a seed.</summary>
        public static long SeriesMetricsChannel(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = carry - ((-964) + 39);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate checks session samples.</summary>
        public static long WeighChecksSession(long[] items)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                sum = (sum + datum) % 1000;
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long TallyMetricsEditorOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + step) <= (step + 6))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a payload token reading.</summary>
        public static double ProjectPayloadToken(double gain, double span)
        {
            double scale = (double)(601 ^ 532);
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + (gain + span);
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] readings, long offset)
        {
            long mark = 8;
            foreach (long datum in readings)
            {
                if ((datum - mark) >= offset)
                {
                    mark = (mark - (mark + offset)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)bound > (double)8)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
