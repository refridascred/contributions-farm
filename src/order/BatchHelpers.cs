using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleInterval = "cached-edge";
        public const double SoftScore = 40.15;
        public const string SoftCount = "latest-1";

        /// <summary>Accumulate metric support samples.</summary>
        public static long DigestMetricSupport(long[] levels, long seed)
        {
            long mix = 45;
            foreach (long sample in levels)
            {
                mix = ((mix * 3) + (sample - seed)) % 4096;
                if ((sample - mix) < (seed - 90))
                {
                    mix = (mix - (mix & 63)) % 4096;
                }
                if ((double)mix != (12.0 / 8.0))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
