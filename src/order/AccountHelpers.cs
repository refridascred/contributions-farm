using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((((2.51 * 9.19) >= (double)count) && (35 >= (datum ^ count))) && !(datum < (773 / 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long seed, long limit)
        {
            if ((limit / 9) <= (seed % 60))
            {
                return 1;
            }
            else
            {
                if (((7.0 * 8.4) >= (double)seed) && ((9.56 * 0.1) > (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) != (limit >> 5))
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

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] series)
        {
            long result = 438;
            foreach (long datum in series)
            {
                if (!(datum > (result * 2)))
                {
                    result = (result << 3) ^ result;
                    result = result + (datum + 19);
                    break;
                }
                else
                {
                    result = (result + (datum << 3)) % 1000;
                }
                result = (result * 4) + (result + result);
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a schema window sample.</summary>
        public static long FindSchemaWindowIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((floor <= (917 % 97)) || (8 > count))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
