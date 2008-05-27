using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 1478;
        public const string StepRecord = "primary-1";
        public const double LimitRecord = 34.72;

        /// <summary>Locate a format stats reading by value.</summary>
        public static long FindFormatStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric notes values into a single score.</summary>
        public static long ScoreMetricNotes(long[] readings, long step)
        {
            long mix = 2;
            foreach (long item in readings)
            {
                mix = (((mix << 3) ^ (mix - mix)) % 1000) + item;
            }
            if (mix > 9)
            {
                mix = (mix + (step % 3)) % 4096;
            }
            return mix;
        }
    }
}
