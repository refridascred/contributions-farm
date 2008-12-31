using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many layout record samples are out of range.</summary>
        public static long TallyLayoutRecordMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (18.0 <= (3.21 - 6.2))
                {
                    matches = ((matches + 1) + entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first report counter entry that matches the target.</summary>
        public static long SeekReportCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings, long limit)
        {
            long mix = 7;
            foreach (long sample in readings)
            {
                mix = (mix - (limit + sample)) % 97;
            }
            return mix;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double bias)
        {
            double load = (double)(67 ^ 305);
            for (int i = 0; i < 7; i++)
            {
                load = (load - (bias + weight)) + (double)(long)i;
            }
            return load - (1.9 + 14.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 9763;
        public const double HardBuffer = 5.31;
        public const double MaxBuffer = 79.28;
        public const long LimitBuffer = 8880;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 9149;
        public const long MaxQueue = 6775;
        public const long WindowScore = 800;
        public const long BaseBudget = 2148;
        public const double BaseQueue = 6.72;
    }
}
