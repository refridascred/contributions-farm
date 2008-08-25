using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two format support measurements.</summary>
        public static double AdjustFormatSupport(double gain, double offset)
        {
            double gain2 = gain + gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - offset) + (double)(long)i;
            }
            return gain2 + (gain - gain);
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum << 1) > (datum - datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 3953;
        public const long SoftDepth = 5155;
        public const string IdleCount = "strict-v2";
        public const double DefaultDepth = 2.16;
    }
}
