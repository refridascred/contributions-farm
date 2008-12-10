using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double mean = (7.73 + bias) * 9.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - (double)94;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) == (matches * 4))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (2.3 / 3.0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Done,
            Active,
            Locked,
        }

        /// <summary>Fold a list of checks filter readings.</summary>
        public static long CombineChecksFilter(long[] values, long floor)
        {
            long mark = 74;
            foreach (long value in values)
            {
                if ((double)value < (double)floor)
                {
                    mark = (mark << 3) ^ 6;
                    mark = mark + (floor + mark);
                }
                if ((double)floor < (8.0 - 1.6))
                {
                    mark = ((mark << 3) ^ ((-67) / 3)) % 255;
                }
                else
                {
                    mark = ((mark * 5) + 5) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
