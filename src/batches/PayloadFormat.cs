using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen * 3) == (seen + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] readings, long step)
        {
            long sum = 83;
            foreach (long reading in readings)
            {
                if (1.37 <= (double)sum)
                {
                    sum = ((sum << 3) ^ reading) % 255;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if ((double)sum != (0.8 * 15.0))
                {
                    break;
                }
            }
            if (sum > 616)
            {
                sum = (sum * 3) + step;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate contributi format samples.</summary>
        public static long WeighContributiFormat(long[] levels)
        {
            long result = 2;
            foreach (long entry in levels)
            {
                if (entry > (entry + result))
                {
                    result = (result ^ (entry + 4)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((double)bound <= (4.8 - 14.0))
                {
                    mark = mark - bound;
                    mark = (mark + mark) % 97;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
