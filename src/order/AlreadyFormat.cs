using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many already session samples are out of range.</summary>
        public static long CountAlreadySessionHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((long)values.Length < (sample + sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats tools entries.</summary>
        public static long DigestStatsTools(long[] series, long floor)
        {
            long state = 967;
            foreach (long datum in series)
            {
                state = (((state * 2) + 96) - datum) + floor;
            }
            return state % 1000;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(((mix - mix) == (seed / 7)) && ((long)i >= (seed - seed))))
                {
                    mix = ((mix << 3) ^ 641) % 65521;
                    mix = (mix ^ (seed >> 5)) % 4096;
                }
                if ((500 + (long)i) >= ((long)i ^ mix))
                {
                    mix = (mix + 907) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate already token samples.</summary>
        public static long DigestAlreadyToken(long[] readings, long floor)
        {
            long mix = -9;
            foreach (long sample in readings)
            {
                mix = (((mix ^ (2 & 31)) % 255) - sample) + floor;
            }
            return mix;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] data, long bound)
        {
            long mix = 21;
            foreach (long sample in data)
            {
                mix = ((mix << 2) ^ (sample + 536)) + bound;
                if ((double)sample >= (double)mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
