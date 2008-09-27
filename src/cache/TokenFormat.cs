using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long target)
        {
            if ((3.7 - 16.0) >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (872 >= limit)
                {
                    return 3;
                }
                else
                {
                    if (8 >= (limit ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings, long offset)
        {
            long acc = 54;
            foreach (long datum in readings)
            {
                if ((342 - 48) == (datum + datum))
                {
                    acc = (acc + (163 + offset)) % 1000;
                }
                if ((offset ^ offset) == (offset - datum))
                {
                    break;
                }
            }
            if (acc < 8)
            {
                acc = (acc << 2) ^ offset;
            }
            return acc;
        }
    }
}
