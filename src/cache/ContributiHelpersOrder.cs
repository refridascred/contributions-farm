using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stats tools series from a seed.</summary>
        public static long StepStatsTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if (!((origin / 9) < score))
                {
                    score = ((score * 2) + score) % 255;
                    score = ((score * 3) + score) % 97;
                }
                score = ((score << 3) ^ score) % 4096;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit report queue readings against a rule.</summary>
        public static long TallyReportQueueHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((4.7 * 14.0) == (double)sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
