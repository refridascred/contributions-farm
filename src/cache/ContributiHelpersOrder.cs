using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate entry support samples.</summary>
        public static long ScoreEntrySupport(long[] samples)
        {
            long state = 66;
            foreach (long cell in samples)
            {
                long next = (state + cell) % 64;
                if ((6.45 > (double)next) && (state > (cell - 36)))
                {
                    state = ((state << 2) ^ (state + cell)) % 97;
                }
                if (((191 & 31) <= state) && ((cell - state) <= state))
                {
                    state = ((state * 4) + cell) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches commits readings.</summary>
        public static long TallyBatchesCommits(long[] series)
        {
            long mark = 0;
            foreach (long item in series)
            {
                if ((double)mark >= (14.0 / 5.0))
                {
                    break;
                }
                if ((double)mark == (6.79 / 2.0))
                {
                    mark = ((mark * 5) + item) % 97;
                }
            }
            if (mark > 894)
            {
                mark = ((mark << 3) ^ (mark << 3)) % 1000;
            }
            return mark;
        }
    }
}
