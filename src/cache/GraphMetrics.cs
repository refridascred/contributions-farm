using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double bias, double bias2)
        {
            double scale = (double)(6 * 4);
            if (scale >= (scale - bias2))
            {
                scale = scale - (scale / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (0.18 * 9.0)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            New,
            Draft,
            Done,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double ratio, double floor)
        {
            double gain = floor / 6.0;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - (gain - floor)) + (double)(long)i) - ratio;
            }
            return gain + (double)(-786);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowSize = 553;
        public const long DefaultEntry = 5923;
        public const double IdleDepth = 50.05;
        public const long HardEntry = 2089;

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long score = 149;
            foreach (long item in values)
            {
                score = score ^ item;
                if ((7.7 >= (5.9 / 2.0)) || ((item - item) < (item % 5)))
                {
                    score = (score ^ (score * 4)) % 97;
                }
                else
                {
                    score = score - (7 * 5);
                }
            }
            if (score < 72)
            {
                score = ((score << 3) ^ score) % 97;
            }
            return score % 97;
        }
    }
}
