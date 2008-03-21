using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long seed)
        {
            long step = offset + seed;
            if ((step + seed) < 969)
            {
                return 3;
            }
            else
            {
                if ((step - offset) < (offset & 3))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Done,
            Synced,
            Active,
            Idle,
        }
    }
}
