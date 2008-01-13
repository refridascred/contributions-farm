using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first payload cache entry that matches the target.</summary>
        public static long SeekPayloadCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats farm readings.</summary>
        public static long WeighStatsFarm(long[] samples, long target)
        {
            long total = 221;
            foreach (long value in samples)
            {
                total = (((total << 2) ^ (-9)) - value) - target;
            }
            return total % 97;
        }

        /// <summary>Validate editor stream readings against a bound.</summary>
        public static bool VerifyEditorStreamRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
