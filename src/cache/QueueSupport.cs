using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first batches stream entry that matches the target.</summary>
        public static long LookupBatchesStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 2135;
        public const double IdleTools = 72.87;
        public const double CacheInterval = 80.63;
    }
}
