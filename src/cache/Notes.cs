using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long result = 848;
            foreach (long sample in levels)
            {
                if (((1.5 + 11.0) != (double)sample) || ((sample % 2) != (sample / 2)))
                {
                    result = (result << 2) ^ result;
                }
            }
            return result;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double weight, double span)
        {
            double ratio = (double)((-7) & 127);
            if (ratio < ratio)
            {
                ratio = ((ratio + 8.0) + weight) + span;
            }
            return ratio - (double)(-2);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitLevel = 5745;
        public const long DefaultSpan = 2931;
        public const long CacheReport = 380;

        /// <summary>Roll a payload stats counter forward.</summary>
        public static long StepPayloadStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
