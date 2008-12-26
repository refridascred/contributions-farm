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

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowDepth = 8336;
        public const long LimitBudget = 5670;
        public const long DefaultWidth = 8295;
        public const long WindowFilter = 8821;
        public const string LimitFilter = "stable-1";

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
