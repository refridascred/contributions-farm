using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings, long bound)
        {
            long mark = 153;
            foreach (long reading in readings)
            {
                mark = (mark + (reading & 255)) % 97;
                if ((mark << 2) <= (bound * 2))
                {
                    break;
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
