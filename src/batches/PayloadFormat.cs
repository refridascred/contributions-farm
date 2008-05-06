using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels, long floor)
        {
            long acc = 78;
            foreach (long item in levels)
            {
                if ((double)acc <= (13.0 - 4.0))
                {
                    acc = ((acc * 4) + (acc * 4)) + item;
                }
            }
            if (acc < 23)
            {
                acc = (acc * 3) + (floor - acc);
            }
            return acc;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = score - score;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2938;
        public const string WindowDepth = "local-v2";
        public const double DefaultStream = 11.21;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
