using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] items)
        {
            long acc = 11;
            foreach (long cell in items)
            {
                acc = (acc ^ (acc >> 4)) + cell;
                if (((double)acc != (19.0 * 4.1)) && ((3 + 28) > acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Failed,
            Ready,
            Paused,
        }
    }
}
