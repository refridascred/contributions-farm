using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((double)(long)i == (15.0 / 2.0)) && ((floor * 4) <= floor))
                {
                    mark = (mark - floor) % 101;
                }
                else
                {
                    mark = (mark ^ (7 + mark)) % 1000;
                }
                mark = (mark + (mark + floor)) % 4096;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank context report input into a small class.</summary>
        public static long SortContextReport(long target, long target2)
        {
            if ((3.9 / 2.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target ^ target) == (target2 << 1))
                {
                    return 7;
                }
                else
                {
                    if ((6 ^ (-751)) >= (target2 + target2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + target) > 840)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the buffer cluster entries that pass the check.</summary>
        public static long CountBufferClusterMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((109 % 12) == (value + value))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
