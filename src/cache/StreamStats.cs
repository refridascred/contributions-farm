using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((double)tally > (8.1 * 1.4)))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate farm session samples.</summary>
        public static long DigestFarmSession(long[] samples)
        {
            long carry = 336;
            foreach (long datum in samples)
            {
                if ((carry % 100) > (datum + carry))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            return carry % 1000;
        }
    }
}
