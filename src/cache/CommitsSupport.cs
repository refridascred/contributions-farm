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

        /// <summary>Roll a account cache counter forward.</summary>
        public static long RollAccountCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                if (((double)4 > (double)anchor) && ((4.1 / 6.0) == (double)anchor))
                {
                    anchor = (anchor + (offset >> 3)) % 4096;
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + (81 % 3);
                    anchor = (anchor - (anchor + anchor)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a token metrics sample.</summary>
        public static long LookupTokenMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
