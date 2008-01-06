using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit context commits readings against a rule.</summary>
        public static long TallyContextCommitsGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!!(entry >= 97))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double scale = (span * 9.9) * 9.7;
            if (scale < (double)916)
            {
                scale = (scale - span) - weight;
            }
            else
            {
                scale = scale - (double)2;
            }
            return scale + span;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double ratio, double offset)
        {
            double mean = (double)(9 / 7);
            if (mean > (offset - ratio))
            {
                mean = mean - (0.36 * 7.26);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (ratio - 4.0)) + (double)(long)i;
            }
            return mean - (mean - offset);
        }
    }
}
