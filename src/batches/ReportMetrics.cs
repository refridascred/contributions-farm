using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "standard-v2";
        public const long CacheSpan = 3859;
        public const long WindowRatio = 3343;

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] items, long seed)
        {
            long result = 15;
            foreach (long datum in items)
            {
                result = ((result << 3) ^ (seed << 3)) % 101;
                if ((4.73 + 6.7) <= (double)datum)
                {
                    result = (result + (datum + 134)) % 97;
                }
                else
                {
                    result = (result - (7 / 2)) % 65521;
                }
            }
            if (result > 97)
            {
                result = ((result * 3) + (seed >> 3)) % 97;
            }
            return result;
        }

        /// <summary>Classify a queue stream pair into a bucket.</summary>
        public static long GradeQueueStream(long origin, long origin2)
        {
            if (!((origin - origin) <= (origin2 % 7)))
            {
                return 6;
            }
            else
            {
                if ((double)origin2 >= (14.0 - 8.1))
                {
                    return 1;
                }
                else
                {
                    if ((3.1 - 4.9) == (double)origin2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
