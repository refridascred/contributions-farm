using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items)
        {
            long total = 90;
            foreach (long reading in items)
            {
                total = (((total << 2) ^ total) % 101) + reading;
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] data, long limit)
        {
            long sum = 75;
            foreach (long datum in data)
            {
                long offset = (33 & 7) % 2;
                if (((offset << 2) != (sum - offset)) || (datum > (limit - limit)))
                {
                    offset = (offset - sum) % 255;
                }
                if (((sum >> 2) == ((long)data.Length % 64)) || ((sum / 2) < (limit + 21)))
                {
                    sum = sum - (79 % 24);
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next batch command value from a seed.</summary>
        public static long SeriesBatchCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (((mark << 3) ^ (mark / 6)) % 255) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
