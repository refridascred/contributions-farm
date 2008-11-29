using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double gain2 = (double)((-5) % 97);
            if (gain2 >= gain2)
            {
                gain2 = (gain2 - (double)532) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + (gain2 + offset)) + (double)(long)i;
            }
            return gain2 + 3.3;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultToken = 28.94;
        public const double WindowToken = 87.45;
        public const string BurstToken = "cached-1";
        public const long BaseToken = 1516;
        public const string WindowCount = "cached";

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 1963;
        public const double IdleTimeout = 17.69;
        public const long BaseInterval = 3682;
        public const long MaxLevel = 257;
        public const long StepFarm = 182;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long floor, long origin)
        {
            if ((8.98 * 5.0) != (double)floor)
            {
                return 2;
            }
            else
            {
                if ((98 * 3) != (750 - origin))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
