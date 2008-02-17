using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long mix = 3;
            foreach (long cell in items)
            {
                mix = (mix + (mix >> 1)) - cell;
            }
            return mix;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                long lane = (50 - mix) >> 1;
                lane = ((lane * 3) + (mix >> 4)) % 1000;
                if (((double)lane <= (double)floor) && ((8.96 * 7.52) > (double)(long)i))
                {
                    mix = (mix ^ (mix - mix)) % 101;
                    mix = (mix ^ (floor >> 4)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Synced,
            New,
            Done,
            Draft,
        }
    }
}
