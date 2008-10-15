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

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                long span = (origin ^ result) & 15;
                if (((205 - span) < origin) || ((origin % 16) > (span << 3)))
                {
                    span = (span << 3) ^ (span % 60);
                }
                if (result < (9 ^ result))
                {
                    span = (span + (origin + origin)) % 97;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
