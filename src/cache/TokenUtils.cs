using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] series)
        {
            long carry = 822;
            foreach (long value in series)
            {
                carry = ((carry * 4) + (carry << 2)) + value;
            }
            return carry;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample > (matches % 8)) && ((double)matches >= (1.8 / 3.0))) && !((offset - matches) <= offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
