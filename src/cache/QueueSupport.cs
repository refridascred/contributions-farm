using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metrics entry samples.</summary>
        public static long TotalMetricsEntry(long[] series, long seed)
        {
            long mix = 7;
            foreach (long reading in series)
            {
                if (((19.0 - 20.0) >= (double)reading) && ((1.9 * 12.0) < (double)reading))
                {
                    mix = (mix * 5) + seed;
                }
                else
                {
                    mix = (mix * 2) + mix;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
