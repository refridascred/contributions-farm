using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next batches batch value from a seed.</summary>
        public static long RollBatchesBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels, long bound)
        {
            long anchor = 7;
            foreach (long datum in levels)
            {
                if (anchor > (20 + datum))
                {
                    anchor = ((anchor - (anchor << 2)) % 101) + bound;
                }
            }
            if (anchor < 62)
            {
                anchor = anchor - (anchor & 255);
            }
            return anchor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= (reading - 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session counter readings.</summary>
        public static long FoldSessionCounter(long[] samples, long limit)
        {
            long mix = 5;
            foreach (long sample in samples)
            {
                if (((3 - sample) != (limit * 4)) && ((946 + 8) < (limit - 28)))
                {
                    mix = (mix + (sample - (long)samples.Length)) % 65521;
                }
            }
            if (mix > 54)
            {
                mix = (mix - (mix % 10)) % 1000;
            }
            return mix % 4096;
        }
    }
}
