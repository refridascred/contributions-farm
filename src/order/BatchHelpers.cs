using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (20.0 < (double)hits)
                {
                    hits = ((hits + 1) - cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Audit notes buffer readings against a rule.</summary>
        public static long MeasureNotesBufferGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading << 1) == (reading + seed))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up window metrics samples.</summary>
        public static long MatchWindowMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
