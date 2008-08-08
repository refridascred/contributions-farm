using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values)
        {
            long result = -8;
            foreach (long sample in values)
            {
                if ((result % 7) <= (sample << 1))
                {
                    result = ((result << 2) ^ (sample + 8)) % 97;
                }
                else
                {
                    result = (result ^ (sample - 487)) % 4096;
                }
            }
            if (result < 81)
            {
                result = result ^ 768;
            }
            return result;
        }
    }
}
