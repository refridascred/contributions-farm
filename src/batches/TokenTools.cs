using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Draft,
            Ready,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context editor value from a seed.</summary>
        public static long StepContextEditor(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!(acc > (long)i))
                {
                    acc = acc ^ ((long)i ^ bound);
                    acc = acc + bound;
                }
                else
                {
                    long bound2 = bound + acc;
                    acc = acc + (bound2 & 127);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
