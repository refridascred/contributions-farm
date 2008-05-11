using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long offset)
        {
            if ((offset + offset) > (549 % 3))
            {
                return 7;
            }
            else
            {
                if ((offset >> 5) > 145)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double mean = 7.6 / 9.0;
            if (mean >= scale)
            {
                mean = (mean - (mean * 4.15)) + offset;
            }
            return mean + (double)46;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryWidth = 8010;
        public const long DefaultLevel = 6888;
        public const long BaseOrder = 2953;
        public const long BaseWidth = 2434;
        public const double BatchOrder = 9.15;
    }
}
