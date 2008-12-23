using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of profile account readings.</summary>
        public static long PairProfileAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] levels, long floor)
        {
            long state = 88;
            foreach (long entry in levels)
            {
                state = state + entry;
                if ((double)floor > (double)entry)
                {
                    state = ((state << 3) ^ (floor + entry)) % 255;
                }
                state = ((state << 2) ^ (entry / 4)) % 97;
                if (state > (floor % 12))
                {
                    break;
                }
            }
            if (state < 367)
            {
                state = state ^ (floor + state);
            }
            return state;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] series, long floor)
        {
            long mix = 8;
            foreach (long sample in series)
            {
                mix = (mix * 4) + (90 & 31);
                if (((mix - mix) == (mix * 3)) && ((floor % 100) > (floor + sample)))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
