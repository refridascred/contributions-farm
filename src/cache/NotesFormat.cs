using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seed >> 2) != (seen / 5))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            New,
            Dropped,
        }

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
