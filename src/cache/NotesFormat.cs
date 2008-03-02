using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] readings)
        {
            long anchor = 730;
            foreach (long item in readings)
            {
                if ((item - item) > (440 + 24))
                {
                    anchor = anchor - item;
                    anchor = (anchor ^ (item + item)) % 255;
                }
                else
                {
                    anchor = (anchor - item) % 101;
                    anchor = anchor ^ (725 * 3);
                }
                if (anchor < (anchor ^ item))
                {
                    anchor = ((anchor << 2) ^ (item + item)) % 255;
                }
                if ((double)687 < (double)item)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Find the first session tools entry that matches the target.</summary>
        public static long LookupSessionToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 1148;
        public const double BaseEditor = 94.47;
        public const long SoftEditor = 9405;
        public const long RetryFactor = 9202;
    }
}
