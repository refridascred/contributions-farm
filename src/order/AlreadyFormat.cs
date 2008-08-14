using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double gain = offset;
            if (gain > (16.0 + 11.0))
            {
                gain = gain + (weight * 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (20.0 - 1.4)) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i / 8) < (long)i) || ((double)491 <= (double)limit))
                {
                    acc = (acc ^ (limit - limit)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry ^ (65 / 8)) % 1000;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry ^ 10) - (long)i2;
                }
                if (!((double)(long)i != (double)carry))
                {
                    carry = ((carry * 4) + ((long)i * 4)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
