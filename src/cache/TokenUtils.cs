using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] series)
        {
            long state = 56;
            foreach (long datum in series)
            {
                long edge = (state << 1) - (datum ^ 742);
                state = ((state << 2) ^ (edge * 5)) % 97;
                if ((double)datum < 1.0)
                {
                    state = state ^ (datum << 3);
                }
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of window already readings.</summary>
        public static long CompareWindowAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
