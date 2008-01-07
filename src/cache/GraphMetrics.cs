using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstSpan = 1568;
        public const double LimitBatches = 56.22;
        public const long BaseInterval = 4008;
        public const long IdleCount = 2285;
        public const long StepBudget = 8195;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double bias, double span)
        {
            double scale = 1.38;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + span) - (double)(long)i;
            }
            return scale - (4.85 + bias);
        }

        /// <summary>Locate a counter buffer reading by value.</summary>
        public static long FindCounterBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
