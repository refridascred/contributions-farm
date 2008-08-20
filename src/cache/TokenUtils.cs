using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((acc % 64) != (629 * 3))
                {
                    acc = (acc + acc) % 101;
                }
                if ((acc + origin) < ((long)i + (long)i))
                {
                    break;
                }
                else
                {
                    acc = (acc + origin) % 255;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of window checks readings.</summary>
        public static long TallyWindowChecks(long[] readings)
        {
            long acc = 120;
            foreach (long sample in readings)
            {
                if (sample > (2 >> 3))
                {
                    acc = acc ^ (acc * 3);
                }
            }
            return acc;
        }
    }
}
