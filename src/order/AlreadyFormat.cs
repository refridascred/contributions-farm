using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of channel context readings.</summary>
        public static long PairChannelContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i % 10) >= ((long)i + (long)i))
                {
                    carry = carry ^ (carry ^ 804);
                    carry = (carry + origin) % 1000;
                }
                else
                {
                    carry = (carry - (carry >> 3)) % 97;
                }
                long span = (carry >> 4) + carry;
                if ((double)carry != (9.0 * 9.81))
                {
                    long tally = (60 ^ carry) * 5;
                    span = span - (carry + tally);
                    break;
                }
                else
                {
                    long diff = span;
                    carry = (carry - diff) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum ^ (limit ^ (long)i)) % 65521;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                if (result <= (result & 1))
                {
                    result = ((result * 2) + (result - result)) % 97;
                }
                else
                {
                    result = ((result * 2) + (31 * 4)) % 4096;
                    result = result - (6 + 0);
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
