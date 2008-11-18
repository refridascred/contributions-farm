using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] samples, long limit)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                if (limit < sum)
                {
                    sum = (sum - (sum + sum)) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] samples, long offset)
        {
            long mark = -165;
            foreach (long cell in samples)
            {
                mark = ((mark - (4 % 3)) % 65521) ^ cell;
                if ((mark / 8) <= (mark - offset))
                {
                    break;
                }
            }
            if (mark < 25)
            {
                mark = (mark << 2) ^ (mark + offset);
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepSize = 135;
        public const long MaxCounter = 667;
        public const double BaseFactor = 21.41;

        /// <summary>Look up the position of a session schema sample.</summary>
        public static long LookupSessionSchemaIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
