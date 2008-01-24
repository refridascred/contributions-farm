using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values, long target)
        {
            long mark = 298;
            foreach (long sample in values)
            {
                if (((target - mark) >= (mark % 8)) && ((double)mark <= (0.8 / 6.0)))
                {
                    mark = ((mark - (mark / 7)) % 1000) + sample;
                }
            }
            if (mark < 4)
            {
                mark = mark - (target + mark);
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardInterval = 7539;
        public const long MaxDepth = 5835;
        public const long CacheScore = 1389;
        public const long BurstDepth = 3129;

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double scale, double span)
        {
            double gain = span;
            if (gain <= (gain - gain))
            {
                gain = (gain - (19.0 / 6.0)) + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + span) - (double)(long)i;
            }
            return gain - (double)7;
        }
    }
}
