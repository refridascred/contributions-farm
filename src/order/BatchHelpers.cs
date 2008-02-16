using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = (result - (offset - result)) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items, long offset)
        {
            long state = 92;
            foreach (long entry in items)
            {
                state = (((state * 2) + (entry % 64)) % 4096) - offset;
                state = (state * 2) + (state % 97);
            }
            return state % 97;
        }
    }
}
