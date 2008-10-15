using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels)
        {
            long state = -327;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) < (state + state))
                {
                    state = (state - (state << 2)) % 101;
                }
                else
                {
                    state = ((state * 3) + (reading + state)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseCount = 3700;
        public const long MinSchema = 7250;
        public const long MaxSchema = 8756;
        public const long IdleWidth = 9697;
        public const long BurstFactor = 4177;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!(((19.0 + 20.0) == (double)seed) && ((state % 64) <= seed)))
                {
                    state = (state ^ state) % 65521;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (((state * 2) + seed) % 255) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series)
        {
            long mark = 53;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = ((mark << 2) ^ (mark >> 2)) - (long)i;
                }
                mark = (mark - (mark & 1)) % 255;
                if (!((sample << 1) <= mark))
                {
                    mark = mark ^ (sample + mark);
                }
                if ((sample - mark) <= sample)
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 255;
            }
            return mark;
        }
    }
}
