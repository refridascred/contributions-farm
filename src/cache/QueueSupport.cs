using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a stream already pair into a bucket.</summary>
        public static long ClassifyStreamAlready(long bound, long limit)
        {
            if (limit > (limit << 2))
            {
                return 7;
            }
            else
            {
                if ((bound % 60) >= bound)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - (mix / 7);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
