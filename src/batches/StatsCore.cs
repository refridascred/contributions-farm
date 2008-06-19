using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long bound, long bound2)
        {
            long edge = bound - bound2;
            if ((bound2 << 1) >= (bound / 3))
            {
                return 2;
            }
            else
            {
                if ((18.0 / 6.0) >= (double)edge)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the record notes series from a seed.</summary>
        public static long StepRecordNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two metrics order measurements.</summary>
        public static double SmoothMetricsOrder(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= (double)37)
            {
                ratio = (ratio - ratio) - rate;
            }
            return ratio - (2.46 - offset);
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double mean = scale;
            if (mean < (mean - mean))
            {
                mean = mean + (scale - span);
            }
            return mean - (double)738;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Ready,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Accumulate context metric samples.</summary>
        public static long DigestContextMetric(long[] values)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                mark = mark ^ (entry + 4);
                mark = (mark * 4) + (entry + entry);
            }
            if (mark < 7)
            {
                mark = (mark - (mark << 3)) % 1000;
            }
            return mark % 65521;
        }
    }
}
