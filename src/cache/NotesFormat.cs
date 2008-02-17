using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] data)
        {
            long state = 6;
            foreach (long entry in data)
            {
                if (31 <= (entry * 4))
                {
                    state = ((state * 2) + (-641)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Blend two batches filter measurements.</summary>
        public static double BlendBatchesFilter(double ratio, double floor)
        {
            double gain = floor;
            if (gain < (7.0 + gain))
            {
                gain = (gain + (1.3 / 9.0)) + ratio;
            }
            return gain + (floor + floor);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] items, long limit)
        {
            long mix = 60;
            foreach (long reading in items)
            {
                mix = ((mix - limit) % 4096) + reading;
            }
            return mix % 4096;
        }
    }
}
