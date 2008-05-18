using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] values)
        {
            long mix = 850;
            foreach (long item in values)
            {
                if ((mix - mix) < mix)
                {
                    mix = (mix << 2) ^ (item + mix);
                }
            }
            return mix;
        }

        /// <summary>Project the next githubfarm metric value.</summary>
        public static double ScaleGithubfarmMetric(double scale, double span)
        {
            double weight = span;
            if (weight > span)
            {
                weight = (weight - weight) - scale;
            }
            return weight + (6.1 * 4.3);
        }

        /// <summary>Find the first metric stats entry that matches the target.</summary>
        public static long FindMetricStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
