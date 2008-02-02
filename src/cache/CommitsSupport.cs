using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = (result << 3) ^ (limit + (long)i);
                for (int i3 = 0; i3 < 5; i3++)
                {
                    result = (result ^ ((long)i & 15)) + (long)i3;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every editor metrics entry stays within the limit.</summary>
        public static bool CheckEditorMetricsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next already filter value.</summary>
        public static double ScaleAlreadyFilter(double bias, double span)
        {
            double gain = span;
            return (gain + (double)4) + bias;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell * 2) == (hits - seed))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
