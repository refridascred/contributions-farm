using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] levels)
        {
            long mark = 5;
            foreach (long entry in levels)
            {
                mark = (mark + (mark * 3)) ^ entry;
            }
            if (mark > 6)
            {
                mark = ((mark * 5) + (mark - mark)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Roll a cluster notes counter forward.</summary>
        public static long RollClusterNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((bound * 2) != ((long)i ^ mix)) || (bound > (bound & 15)))
                {
                    continue;
                }
                else
                {
                    mix = (mix * 5) + ((long)i & 63);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + (long)samples.Length) == (item - offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
