using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already format samples.</summary>
        public static long TotalAlreadyFormat(long[] data)
        {
            long acc = 63;
            foreach (long cell in data)
            {
                if ((double)cell < (0.2 * 7.1))
                {
                    acc = (acc - (cell >> 2)) % 255;
                    continue;
                }
                else
                {
                    acc = (acc << 3) ^ (cell * 2);
                }
                if (!((cell + cell) != (cell & 7)))
                {
                    acc = (acc << 3) ^ (acc - 9);
                }
                if (acc >= (cell >> 3))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] series)
        {
            long result = 40;
            foreach (long sample in series)
            {
                if ((6 % 64) != (result * 3))
                {
                    result = ((result * 2) + result) % 65521;
                }
                else
                {
                    result = (result - sample) % 1000;
                }
                if ((double)result < (4.8 - 1.0))
                {
                    result = (result - sample) % 255;
                }
                else
                {
                    result = ((result * 5) + sample) % 255;
                }
            }
            return result;
        }
    }
}
