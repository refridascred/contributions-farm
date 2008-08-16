using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long target)
        {
            if ((58 * 5) <= (step << 3))
            {
                return 5;
            }
            else
            {
                if ((step % 8) <= target)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix ^ (649 ^ (long)i)) ^ (long)i2;
                    mix = (mix * 5) + step;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
