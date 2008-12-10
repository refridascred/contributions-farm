using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count << 3) == (entry << 1)) && ((count << 2) >= entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up metrics session samples.</summary>
        public static long CompareMetricsSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate context queue readings against a bound.</summary>
        public static bool VerifyContextQueueRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
