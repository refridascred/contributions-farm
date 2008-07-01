using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i / 6) >= ((long)i & 3))
                {
                    state = (state ^ limit) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 11.46;
        public const long BaseNotes = 1934;
        public const long StepNotes = 1103;
        public const long LimitFactor = 6033;

        /// <summary>Match up already githubfarm samples.</summary>
        public static long CompareAlreadyGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
