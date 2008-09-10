using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                if (offset > (0 * 4))
                {
                    mix = mix ^ (offset / 3);
                    break;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the commits graph series from a seed.</summary>
        public static long DeriveCommitsGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score ^ score) % 97) ^ (long)i2;
                }
                score = (score ^ score) % 97;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
