using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Queued,
            Stale,
            Ready,
            Active,
        }
    }
}
