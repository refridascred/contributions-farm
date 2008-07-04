using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSpan = 2270;
        public const string BatchNotes = "alpha";
        public const long WindowWidth = 8435;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] items, long target)
        {
            long sum = 24;
            foreach (long datum in items)
            {
                sum = (((sum * 3) + target) % 65521) ^ datum;
            }
            if (sum > 78)
            {
                sum = sum + (sum >> 3);
            }
            return sum;
        }
    }
}
