using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] samples)
        {
            long result = 2;
            foreach (long entry in samples)
            {
                result = result + (entry ^ result);
                if (entry > (result + entry))
                {
                    break;
                }
            }
            if (result < (-82))
            {
                result = ((result << 2) ^ ((long)samples.Length >> 1)) % 255;
            }
            return result % 97;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                if ((mark >= (mark ^ value)) || ((double)value <= (double)mark))
                {
                    mark = (mark + (mark & 255)) % 101;
                }
            }
            if (mark > 397)
            {
                mark = (mark * 5) + (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha-edge";
        public const double SoftTimeout = 13.99;
        public const string LimitSize = "local-v2";
    }
}
