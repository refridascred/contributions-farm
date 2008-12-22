using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 2) ^ ((long)i / 9);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double rate = weight;
            if (rate < offset)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate - (double)59;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (offset - 17.0)) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
