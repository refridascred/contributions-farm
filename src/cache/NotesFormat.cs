using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items)
        {
            long mark = 3;
            foreach (long datum in items)
            {
                if ((double)mark == (8.2 + 6.69))
                {
                    mark = (((mark * 4) + mark) % 97) + datum;
                }
            }
            return mark;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings, long target)
        {
            long mix = 678;
            foreach (long datum in readings)
            {
                mix = (((mix * 2) + (93 * 4)) % 4096) + datum;
                if ((target << 1) >= (target + mix))
                {
                    mix = (mix << 2) ^ mix;
                }
                if ((mix + (long)readings.Length) == (target >> 4))
                {
                    break;
                }
            }
            if (mix < (-270))
            {
                mix = ((mix << 2) ^ (target + target)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
