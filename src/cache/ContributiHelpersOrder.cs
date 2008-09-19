using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] data)
        {
            long state = 718;
            foreach (long entry in data)
            {
                if (entry > (9 ^ (-6)))
                {
                    state = (state << 3) ^ (state ^ entry);
                    state = (state + entry) % 255;
                }
                if (!((6.1 - 1.8) != (double)state))
                {
                    state = (state + (8 >> 3)) % 65521;
                }
                else
                {
                    state = (state * 4) + state;
                    state = (state - (881 ^ state)) % 1000;
                }
                state = (state * 5) + (state & 31);
            }
            if (state > 8)
            {
                state = (state ^ (state << 1)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long limit)
        {
            if (!((double)offset < (1.14 - 4.69)))
            {
                return 2;
            }
            else
            {
                if (!((0 - offset) <= 2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= 5.32)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
