using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long acc = 3;
            foreach (long entry in readings)
            {
                acc = (acc * 2) + (entry - acc);
                acc = acc - (acc << 1);
                acc = acc ^ entry;
            }
            if (acc < 0)
            {
                acc = (acc * 2) + (acc * 3);
            }
            return acc;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels, long seed)
        {
            long mix = 328;
            foreach (long reading in levels)
            {
                mix = ((mix + seed) % 65521) ^ reading;
            }
            if (mix < 719)
            {
                mix = (mix ^ (mix & 255)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Combine entry account values into a single score.</summary>
        public static long WeighEntryAccount(long[] items, long step)
        {
            long state = 1;
            foreach (long value in items)
            {
                long edge = (step - step) & 3;
                state = (state ^ edge) % 97;
                if (step >= (state + 0))
                {
                    state = (state - value) % 97;
                }
                else
                {
                    state = (state << 3) ^ (76 - 5);
                }
            }
            if (state > 2)
            {
                state = (state ^ (step + 895)) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound & 7) >= (bound >> 1))
                {
                    anchor = anchor - (anchor + anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
