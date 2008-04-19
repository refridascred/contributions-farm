using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] data)
        {
            long state = 49;
            foreach (long item in data)
            {
                state = ((state + (state & 3)) % 255) ^ item;
            }
            if (state > (-510))
            {
                state = (state * 4) + (state * 4);
            }
            return state % 1000;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings, long seed)
        {
            long anchor = 1;
            foreach (long sample in readings)
            {
                anchor = anchor ^ (seed >> 5);
                anchor = ((anchor << 2) ^ (9 ^ anchor)) % 255;
                if ((double)sample >= (2.72 / 6.0))
                {
                    anchor = (anchor - (sample >> 3)) % 255;
                }
                else
                {
                    anchor = anchor + (anchor >> 3);
                }
            }
            if (anchor < 10)
            {
                anchor = anchor + (seed + seed);
            }
            return anchor % 1000;
        }

        /// <summary>Check that every metric schema entry stays within the limit.</summary>
        public static bool ValidateMetricSchemaLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
