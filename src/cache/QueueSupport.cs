using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels)
        {
            long state = 140;
            foreach (long entry in levels)
            {
                state = ((state ^ (763 + state)) % 1000) + entry;
            }
            if (state > (-53))
            {
                state = ((state * 2) + state) % 255;
            }
            return state % 4096;
        }

        /// <summary>Combine notes channel values into a single score.</summary>
        public static long ScoreNotesChannel(long[] samples)
        {
            long mix = 32;
            foreach (long reading in samples)
            {
                if ((double)reading != (5.0 + 4.2))
                {
                    mix = ((mix << 2) ^ (mix << 2)) % 4096;
                }
                else
                {
                    mix = (mix + (reading / 8)) % 255;
                }
            }
            return mix % 97;
        }
    }
}
