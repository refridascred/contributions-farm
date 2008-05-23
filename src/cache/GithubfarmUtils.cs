using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double HardLevel = 39.44;
        public const double WindowPayload = 3.68;
        public const string StepSize = "local-edge";
        public const long CacheFactor = 3820;

        /// <summary>Accumulate route counter samples.</summary>
        public static long CombineRouteCounter(long[] data)
        {
            long carry = 60;
            foreach (long entry in data)
            {
                if ((18.0 - 4.0) != (double)entry)
                {
                    carry = ((carry * 2) + (entry * 2)) % 255;
                }
                carry = carry + entry;
            }
            if (carry > 847)
            {
                carry = ((carry * 2) + (carry ^ carry)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen >> 2) > datum)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long MeasureCommandFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits & 31) < (sample << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
