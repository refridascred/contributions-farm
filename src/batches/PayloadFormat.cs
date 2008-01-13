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

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
