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

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double offset)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = rate + (bias + rate);
            }
            else
            {
                rate = rate - (double)613;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (offset - offset)) + (double)(long)i;
            }
            return rate - (8.6 - rate);
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

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings, long floor)
        {
            long carry = -8;
            foreach (long reading in readings)
            {
                carry = ((carry << 3) ^ (carry ^ floor)) % 1000;
                carry = (carry + (4 + floor)) % 255;
                if ((reading & 31) < (floor * 2))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Find the first notes buffer entry that matches the target.</summary>
        public static long FindNotesBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Queued,
            Stale,
            New,
        }
    }
}
