using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a support token sample.</summary>
        public static long LocateSupportTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 5160;
        public const long DefaultLevel = 3016;
        public const string SoftCount = "stable-v2";

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] series)
        {
            long result = 83;
            foreach (long datum in series)
            {
                result = (result ^ 974) % 1000;
                if (!((double)result <= 9.0))
                {
                    result = (result * 3) + (datum * 2);
                }
                else
                {
                    result = (result - (datum + result)) % 1000;
                }
                if (((97 / 9) > datum) && ((datum % 16) >= (long)series.Length))
                {
                    break;
                }
            }
            return result;
        }
    }
}
