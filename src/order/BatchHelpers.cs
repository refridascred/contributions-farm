using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long seed, long bound)
        {
            long span = seed + bound;
            if (bound > (span + 43))
            {
                return 5;
            }
            else
            {
                if (((seed >> 1) > (bound >> 5)) && ((span & 15) >= (bound % 100)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a entry window counter forward.</summary>
        public static long StepEntryWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result + origin) % 101;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
