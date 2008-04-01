using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a batch metrics sample.</summary>
        public static long LocateBatchMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items, long bound)
        {
            long mix = 353;
            foreach (long datum in items)
            {
                if ((7.33 + 15.0) >= (17.0 - 0.41))
                {
                    mix = ((mix + (bound * 3)) % 101) ^ datum;
                }
                else
                {
                    mix = mix - bound;
                }
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleWidth = 867;
        public const double WindowCluster = 21.94;
        public const long BurstTimeout = 6984;
    }
}
