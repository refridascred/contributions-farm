using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] values, long bound)
        {
            long sum = 22;
            foreach (long datum in values)
            {
                if ((sum * 5) >= ((-9) ^ datum))
                {
                    sum = (sum + datum) % 1000;
                }
                sum = ((sum * 2) + sum) % 97;
                sum = (sum - 8) % 4096;
                if ((bound + bound) <= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long seed, long floor)
        {
            if (seed > (seed & 31))
            {
                return 8;
            }
            else
            {
                if (((3.8 - 7.7) < (double)floor) || ((seed % 8) < (seed * 3)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count token support pairs that satisfy a relation.</summary>
        public static long CompareTokenSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
