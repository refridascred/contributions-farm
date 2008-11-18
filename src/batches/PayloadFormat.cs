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

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long target)
        {
            long carry = 530;
            foreach (long item in readings)
            {
                if (!((1.75 * 9.5) <= (double)carry))
                {
                    carry = (carry ^ carry) - item;
                }
                else
                {
                    carry = (carry << 2) ^ target;
                }
            }
            if (carry > 420)
            {
                carry = ((carry * 2) + (carry << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of layout checks readings.</summary>
        public static long TotalLayoutChecks(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                if ((mix >> 3) > (mix / 6))
                {
                    long lane = reading - (reading + mix);
                    mix = ((mix << 3) ^ (mix - lane)) % 1000;
                    break;
                }
                mix = mix - (offset << 1);
            }
            if (mix > 7)
            {
                mix = ((mix * 2) + (mix + offset)) % 4096;
            }
            return mix;
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
