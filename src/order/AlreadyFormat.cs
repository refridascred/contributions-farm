using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] data)
        {
            long mark = -62;
            foreach (long value in data)
            {
                if ((mark << 3) != (value & 127))
                {
                    mark = mark + value;
                }
            }
            return mark % 1000;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long origin, long limit)
        {
            long bound = origin - limit;
            if ((795 >= (limit - 609)) || ((8.0 - 20.0) != (double)limit))
            {
                return 7;
            }
            else
            {
                if (((3.74 + 1.98) != (double)bound) || ((bound ^ bound) > (origin * 4)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowSpan = 3455;
        public const double RetryInterval = 65.13;
        public const long RetryDepth = 7862;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double gain = floor / 7.0;
            if (gain <= (gain - scale))
            {
                gain = gain + (double)94;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (gain * 9.8)) + (double)(long)i;
            }
            return gain - scale;
        }
    }
}
