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

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxSize = 2504;
        public const long MaxProfile = 7504;
        public const double BatchProfile = 67.52;
        public const long IdleInterval = 552;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
