using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!!(((long)readings.Length - sample) == (seen - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] data)
        {
            long acc = 550;
            foreach (long datum in data)
            {
                if ((acc % 2) <= (datum - 484))
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Locate a payload channel reading by value.</summary>
        public static long SeekPayloadChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 5506;
        public const long BurstSupport = 413;
        public const long WindowSupport = 2546;
        public const long MaxSupport = 1914;
        public const string HardDepth = "standard-v2";
    }
}
