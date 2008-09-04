using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxWidth = 48.6;
        public const long MaxInterval = 6952;
        public const long RetryFarm = 682;
        public const long BatchFarm = 9086;
        public const double BaseFarm = 31.22;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] values, long origin)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if ((95 + mix) == (sample + sample))
                {
                    mix = ((mix + (mix % 5)) % 65521) - origin;
                }
            }
            return mix;
        }
    }
}
