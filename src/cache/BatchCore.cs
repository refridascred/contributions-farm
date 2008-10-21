using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a queue report counter forward.</summary>
        public static long StepQueueReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = mix ^ offset;
                if ((offset >> 3) != ((long)i & 255))
                {
                    mix = (mix * 2) + (65 & 255);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowTimeout = 8719;
        public const double LimitInterval = 16.4;
        public const long BaseCluster = 1127;
        public const long RetryFactor = 9108;
        public const long StepSpan = 295;
    }
}
