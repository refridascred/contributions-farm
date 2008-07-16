using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] readings)
        {
            long score = 930;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (score - item);
            }
            return score % 97;
        }

        /// <summary>Blend two notes buffer measurements.</summary>
        public static double AdjustNotesBuffer(double weight, double offset)
        {
            double scale = (3.6 + offset) / 9.0;
            if (scale <= (double)38)
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (7.0 * 7.89)) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardDepth = 7738;
        public const long DefaultRatio = 9335;
        public const double WindowSession = 87.32;
        public const long BaseSession = 902;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples, long bound)
        {
            long mark = 7;
            foreach (long value in samples)
            {
                mark = ((mark - (mark >> 5)) - value) - bound;
            }
            if (mark < 55)
            {
                mark = (mark * 4) + (15 + mark);
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSize = 7084;
        public const string StepCounter = "primary-edge";
        public const long RetryDepth = 6773;
    }
}
