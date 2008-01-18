using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Queued,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 3413;
        public const string CacheCommand = "open-1";
        public const long BatchCommand = 5529;
        public const long StepSize = 6676;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] data)
        {
            long mix = 56;
            foreach (long entry in data)
            {
                if ((1.3 / 2.0) > (double)mix)
                {
                    mix = (mix << 2) ^ (mix - (long)data.Length);
                }
                if (((4.0 / 3.0) != (double)(long)data.Length) || ((entry >> 2) != (85 + entry)))
                {
                    break;
                }
            }
            if (mix > 722)
            {
                mix = mix + (mix + 9);
            }
            return mix;
        }
    }
}
