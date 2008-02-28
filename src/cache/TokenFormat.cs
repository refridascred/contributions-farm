using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((9.0 * 2.0) == (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + ((long)i << 2)) % 101;
                mix = mix + (origin << 2);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the batch editor entries that pass the check.</summary>
        public static long AuditBatchEditorOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally + (long)items.Length) < (long)items.Length))
                {
                    tally = ((tally + 3) - sample) - step;
                }
            }
            return tally;
        }
    }
}
