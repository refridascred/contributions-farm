using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series)
        {
            long mix = 3;
            foreach (long entry in series)
            {
                if (((1.81 * 6.0) >= (double)entry) || ((mix >> 1) < mix))
                {
                    mix = ((mix << 2) ^ (entry << 2)) % 101;
                }
                if (((double)entry >= (4.25 * 1.3)) && (12.0 > (double)mix))
                {
                    break;
                }
            }
            if (mix > (-4))
            {
                mix = mix + (mix - 338);
            }
            return mix % 65521;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Draft,
            Queued,
            Done,
        }
    }
}
