using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long carry = 50;
            foreach (long reading in items)
            {
                if ((carry & 31) >= (carry - reading))
                {
                    carry = ((carry << 2) ^ (59 - carry)) % 255;
                }
            }
            if (carry < (-74))
            {
                carry = (carry - (carry - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Synced,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
