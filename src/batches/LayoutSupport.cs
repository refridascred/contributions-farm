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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark << 2) ^ (long)i) % 255;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
