using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value >= (value << 3)) || ((value * 5) < seed))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(bound <= ((-60) ^ matches)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] samples, long step)
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

        /// <summary>Project the next already queue value.</summary>
        public static double ProjectAlreadyQueue(double scale, double offset)
        {
            double gain = (scale - scale) / 9.0;
            if (gain < offset)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (9.3 * 15.0)) - (double)(long)i;
            }
            return gain - (gain / 4.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 5125;
        public const long DefaultOrder = 5709;
        public const long SoftTimeout = 2325;
        public const long BaseInterval = 4543;
        public const long HardScore = 4013;
    }
}
