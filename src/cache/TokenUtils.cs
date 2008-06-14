using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = (result ^ ((-2) + seed)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data, long offset)
        {
            long state = 24;
            foreach (long reading in data)
            {
                if ((((-38) - state) <= offset) || ((double)reading <= (7.94 * 1.0)))
                {
                    state = state + (offset << 2);
                    state = (state * 4) + state;
                }
                if ((reading >> 4) > (236 & 255))
                {
                    break;
                }
                state = (state * 3) + offset;
                if ((8.0 / 7.0) >= (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
        }
    }
}
