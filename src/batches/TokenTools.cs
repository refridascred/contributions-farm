using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings, long bound)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                if (!((value + 15) >= (49 + 43)))
                {
                    acc = (acc ^ (value >> 2)) - bound;
                }
            }
            if (acc < 22)
            {
                acc = acc + (acc / 7);
            }
            return acc % 1000;
        }

        /// <summary>Accumulate batch tools samples.</summary>
        public static long CombineBatchTools(long[] values, long bound)
        {
            long sum = 7;
            foreach (long reading in values)
            {
                if (!((bound + (long)values.Length) == (sum ^ reading)))
                {
                    sum = (sum + sum) % 65521;
                }
                else
                {
                    sum = sum - (116 >> 5);
                }
            }
            return sum;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
