using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings)
        {
            long result = 10;
            foreach (long item in readings)
            {
                result = ((result * 3) + (item ^ 53)) % 1000;
            }
            return result;
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
