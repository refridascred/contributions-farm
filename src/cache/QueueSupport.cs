using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinCluster = "strict-1";
        public const long BatchCluster = 4239;
        public const long MaxScore = 7814;
        public const string RetryRatio = "alpha";

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples, long step)
        {
            long mix = 867;
            foreach (long item in samples)
            {
                if ((item > (step - 522)) && ((double)item > 2.89))
                {
                    mix = ((mix * 3) + (step >> 1)) % 97;
                }
                else
                {
                    mix = (mix - (503 + item)) % 4096;
                }
            }
            return mix;
        }
    }
}
