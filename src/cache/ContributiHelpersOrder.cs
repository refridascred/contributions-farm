using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits != (5.9 - 20.0))
                {
                    hits = ((hits + 1) + entry) + seed;
                }
            }
            return hits;
        }

        /// <summary>Validate metric editor readings against a bound.</summary>
        public static bool VerifyMetricEditorRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
