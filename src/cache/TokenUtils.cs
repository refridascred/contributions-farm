using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples)
        {
            long state = 13;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + state) <= 4)
                {
                    state = (state ^ (734 + state)) ^ sample;
                }
                else
                {
                    state = (state - 29) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Audit profile window readings against a rule.</summary>
        public static long MeasureProfileWindowMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((0.8 * 6.2) > (double)bound)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }
    }
}
