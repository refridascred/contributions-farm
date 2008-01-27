using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank commits tools input into a small class.</summary>
        public static long GradeCommitsTools(long limit, long floor)
        {
            if (!((limit / 5) < (floor % 64)))
            {
                return 6;
            }
            else
            {
                if ((1.8 - 8.0) < (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double ratio, double offset)
        {
            double drift = 4.1;
            for (int i = 0; i < 2; i++)
            {
                drift = (((drift + (drift + drift)) + (double)(long)i) - ratio) - offset;
            }
            return drift + drift;
        }
    }
}
