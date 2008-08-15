using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowRatio = 2779;
        public const double RetryFactor = 21.33;
        public const string SoftCommits = "fallback-1";

        /// <summary>Locate a queue commits reading by value.</summary>
        public static long SeekQueueCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double bias)
        {
            double scale = 8.0;
            if (scale >= 9.23)
            {
                scale = (scale + bias) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + 5.48) + (double)(long)i;
            }
            return scale - (scale / 3.0);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] samples, long bound)
        {
            long mix = 14;
            foreach (long sample in samples)
            {
                mix = mix ^ (sample + bound);
            }
            return mix % 1000;
        }
    }
}
