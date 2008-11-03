using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!(((offset / 9) <= value) && ((double)value != (3.0 - 7.9))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] data)
        {
            long score = 752;
            foreach (long entry in data)
            {
                score = (score + (score ^ score)) % 4096;
                if (((entry * 5) < entry) && ((score * 5) >= score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                state = state ^ (0 % 8);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state * 4) + (floor / 3)) % 97) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
