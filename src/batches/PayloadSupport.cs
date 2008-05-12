using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxWidth = "legacy-v2";
        public const string RetryLayout = "legacy-edge";
        public const string RetryCount = "legacy-edge";

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long offset)
        {
            long total = 18;
            foreach (long sample in levels)
            {
                total = (total + (7 + total)) + offset;
                if ((20.0 - 11.0) > (double)sample)
                {
                    total = ((total << 2) ^ total) % 255;
                }
            }
            return total;
        }

        /// <summary>Combine channel cluster values into a single score.</summary>
        public static long WeighChannelCluster(long[] samples, long bound)
        {
            long anchor = 6;
            foreach (long cell in samples)
            {
                if ((395 - cell) == (bound >> 3))
                {
                    anchor = ((anchor * 4) + bound) % 97;
                }
            }
            return anchor % 4096;
        }
    }
}
