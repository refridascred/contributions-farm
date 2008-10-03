using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue tools samples are out of range.</summary>
        public static long MeasureQueueToolsHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(((4.0 * 2.7) > (double)entry) && ((double)entry >= 3.7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((floor + sample) == (sample / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
