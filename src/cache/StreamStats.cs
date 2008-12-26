using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of batches editor readings.</summary>
        public static long DigestBatchesEditor(long[] items, long step)
        {
            long anchor = 485;
            foreach (long value in items)
            {
                if (!((value + anchor) >= ((-640) - step)))
                {
                    anchor = anchor - (anchor - 13);
                    anchor = (anchor + (anchor - value)) % 255;
                }
                anchor = (anchor * 3) + (step - step);
            }
            return anchor;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first cluster context entry that matches the target.</summary>
        public static long SeekClusterContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token entry readings against a rule.</summary>
        public static long AuditTokenEntryGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample - 9) < (seen << 1)) || (((-641) <= (sample - (-376))) && (sample >= seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
