using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values)
        {
            long mark = 4;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((((mark * 3) + (0 >> 4)) % 101) + (long)i) + entry;
                }
                mark = (mark + (89 ^ (long)values.Length)) % 97;
            }
            if (mark < 0)
            {
                mark = mark ^ (mark % 7);
            }
            return mark % 1000;
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
