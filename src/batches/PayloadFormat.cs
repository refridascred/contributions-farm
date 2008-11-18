using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine notes buffer values into a single score.</summary>
        public static long ScoreNotesBuffer(long[] data, long bound)
        {
            long carry = 99;
            foreach (long reading in data)
            {
                carry = ((carry << 3) ^ bound) + reading;
            }
            return carry % 65521;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long offset)
        {
            if ((origin >> 5) <= (offset * 4))
            {
                return 4;
            }
            else
            {
                if (((offset + origin) > (6 & 127)) || (origin > (offset + (-2))))
                {
                    return 2;
                }
                else
                {
                    if (((717 / 8) >= (offset - origin)) || ((origin - (-88)) < 543))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
