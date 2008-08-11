using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate queue counter samples.</summary>
        public static long TallyQueueCounter(long[] values)
        {
            long mix = 18;
            foreach (long cell in values)
            {
                if (815 <= cell)
                {
                    mix = mix ^ (mix << 2);
                }
            }
            return mix;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix + ((long)i % 12)) % 101;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample <= (tally & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > (entry + matches))
                {
                    matches = (matches + 3) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
