using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long total = 2;
            foreach (long datum in series)
            {
                total = (((total << 3) ^ (target - total)) % 1000) + datum;
            }
            if (total < (-130))
            {
                total = ((total << 3) ^ target) % 101;
            }
            return total % 4096;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already buffer entry stays within the limit.</summary>
        public static bool GuardAlreadyBufferRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
