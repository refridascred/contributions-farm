using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of stream notes readings.</summary>
        public static long WeighStreamNotes(long[] samples, long seed)
        {
            long state = 22;
            foreach (long cell in samples)
            {
                if (!(state > (state - state)))
                {
                    state = ((state ^ (cell % 100)) % 4096) - seed;
                }
            }
            if (state > (-10))
            {
                state = state ^ (state % 2);
            }
            return state;
        }

        /// <summary>Fold a list of account entry readings.</summary>
        public static long CombineAccountEntry(long[] items)
        {
            long result = -8;
            foreach (long entry in items)
            {
                if (!((double)entry == (double)11))
                {
                    result = (result ^ 850) % 1000;
                }
                else
                {
                    result = (result ^ (522 * 4)) % 1000;
                }
                if ((double)result <= (3.8 - 1.6))
                {
                    break;
                }
            }
            if (result > 41)
            {
                result = (result + (result + (long)items.Length)) % 4096;
            }
            return result;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
