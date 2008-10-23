using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((limit / 8) < 9)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 3) ^ (bound << 1)) % 255) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings)
        {
            long mark = 2;
            foreach (long value in readings)
            {
                if ((double)mark != (8.0 * 2.5))
                {
                    mark = (mark - (mark + value)) % 1000;
                }
                else
                {
                    mark = (mark ^ (value ^ 32)) % 65521;
                }
            }
            if (mark < 9)
            {
                mark = ((mark << 3) ^ (mark >> 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data)
        {
            long acc = 4;
            foreach (long cell in data)
            {
                acc = (acc + (cell & 31)) % 255;
                if ((((-83) / 8) > (28 - cell)) || ((double)acc == (20.0 / 3.0)))
                {
                    acc = (acc ^ 831) % 1000;
                }
            }
            return acc % 97;
        }
    }
}
