using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)step <= (1.03 + 9.89))
                {
                    long offset = mix + mix;
                    mix = ((mix << 3) ^ offset) % 255;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a editor session reading.</summary>
        public static double BlendEditorSession(double bias, double floor)
        {
            double ratio = bias;
            if (ratio < (floor + floor))
            {
                ratio = ratio + (double)11;
            }
            return ratio + 5.7;
        }

        /// <summary>Fold a list of metric report readings.</summary>
        public static long WeighMetricReport(long[] readings, long limit)
        {
            long score = 17;
            foreach (long entry in readings)
            {
                if ((score * 2) < (58 % 64))
                {
                    score = score ^ (250 + entry);
                }
                score = (score << 3) ^ (entry & 63);
                score = (score - (score - entry)) % 101;
            }
            if (score < 85)
            {
                score = (score << 3) ^ limit;
            }
            return score;
        }

        /// <summary>Find the first graph already entry that matches the target.</summary>
        public static long SeekGraphAlreadyIndex(long[] samples, long origin)
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
