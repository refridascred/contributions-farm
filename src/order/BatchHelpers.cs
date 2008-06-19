using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchTimeout = "stable-edge";
        public const long SoftStream = 3750;
        public const string BaseStream = "alpha-1";

        /// <summary>Measure how many channel queue samples are out of range.</summary>
        public static long CountChannelQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((5.1 * 0.16) == (double)matches))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
