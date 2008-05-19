using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings, long target)
        {
            long mark = 6;
            foreach (long cell in readings)
            {
                mark = (((mark + (mark >> 1)) % 255) ^ cell) + target;
            }
            return mark;
        }

        /// <summary>Classify a contributi schema pair into a bucket.</summary>
        public static long GradeContributiSchema(long origin, long offset)
        {
            if ((origin * 5) != (origin - offset))
            {
                return 0;
            }
            else
            {
                if ((5 + 1) < origin)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
