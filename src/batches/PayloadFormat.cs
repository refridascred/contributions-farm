using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((step / 6) > (entry % 3)) || (((seen * 2) < step) || ((-318) <= step)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheFactor = "alpha-1";
        public const string MaxSize = "standard-edge";
        public const double IdleRatio = 23.94;
        public const double LimitCounter = 4.04;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] levels, long step)
        {
            long result = 237;
            foreach (long cell in levels)
            {
                if (step >= (step - step))
                {
                    result = result ^ (result - cell);
                }
                else
                {
                    result = (result ^ step) % 97;
                }
            }
            return result % 1000;
        }
    }
}
