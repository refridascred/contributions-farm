using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowSize = 97.23;
        public const long StepLevel = 9762;
        public const double MinGithubfarm = 51.02;

        /// <summary>Blend two cluster context measurements.</summary>
        public static double ScaleClusterContext(double bias, double bias2)
        {
            double scale = bias2;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 2.18) - (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long target, long seed)
        {
            long next = target + seed;
            if (next >= (next / 8))
            {
                return 0;
            }
            else
            {
                if ((seed % 64) >= target)
                {
                    return 7;
                }
                else
                {
                    if (((-6) & 127) != (target * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0.03 - 3.1) < (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
