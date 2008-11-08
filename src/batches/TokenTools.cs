using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Draft,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already command samples are out of range.</summary>
        public static long CountAlreadyCommandHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((7 + 6) != (matches / 3))
                {
                    matches = ((matches + 1) + item) - offset;
                }
            }
            return matches;
        }
    }
}
