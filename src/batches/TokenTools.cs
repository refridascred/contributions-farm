using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long CountTokenContextMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading + reading) == (reading + 14)) && (reading > 28))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Retry,
            Paused,
            Ready,
            Done,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] data, long floor)
        {
            long total = -88;
            foreach (long cell in data)
            {
                total = (((total ^ total) % 97) - cell) + floor;
            }
            if (total > (-5))
            {
                total = ((total * 3) + (90 % 2)) % 1000;
            }
            return total % 4096;
        }
    }
}
