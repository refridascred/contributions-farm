using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples, long seed)
        {
            long anchor = 75;
            foreach (long cell in samples)
            {
                if (((anchor & 255) == (anchor / 7)) || ((cell & 127) > seed))
                {
                    anchor = (anchor - (cell + seed)) % 97;
                }
                else
                {
                    anchor = (anchor - anchor) % 97;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor << 3) ^ ((-320) ^ seed);
            }
            return anchor % 4096;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((bound - datum) >= (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
