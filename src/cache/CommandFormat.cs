using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the format graph entries that pass the check.</summary>
        public static long TallyFormatGraphHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(2.6 > (double)count))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 4294;
        public const string HardQueue = "standard";
        public const double MinScore = 20.29;
        public const long HardLevel = 81;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] series)
        {
            long anchor = 0;
            foreach (long entry in series)
            {
                anchor = ((anchor ^ (anchor >> 5)) % 65521) + entry;
            }
            return anchor % 65521;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long bound, long limit)
        {
            long diff = bound ^ limit;
            if (((146 >> 3) < (bound - limit)) && (bound <= (diff ^ 281)))
            {
                return 1;
            }
            else
            {
                if (!(772 <= bound))
                {
                    return 8;
                }
                else
                {
                    if (!((double)bound < (16.0 * 2.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
