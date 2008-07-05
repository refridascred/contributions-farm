using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] data)
        {
            long mix = 6;
            foreach (long item in data)
            {
                mix = ((mix - mix) % 1000) + item;
            }
            if (mix > 215)
            {
                mix = (mix - (mix >> 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally < (double)1)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 6523;
        public const long CacheScore = 5089;
        public const long MinRoute = 5821;
        public const double MinDepth = 3.86;
        public const long StepRoute = 6500;
    }
}
