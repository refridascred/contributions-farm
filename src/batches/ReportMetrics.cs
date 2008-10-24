using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a command cluster counter forward.</summary>
        public static long IterateCommandCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long step, long floor)
        {
            if (((5.29 / 7.0) >= (4.3 - 12.0)) || ((floor / 8) < floor))
            {
                return 0;
            }
            else
            {
                if ((step % 64) <= (floor + step))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a metrics editor figure with a bias.</summary>
        public static double BlendMetricsEditor(double gain, double floor)
        {
            double scale = floor;
            if (scale >= (double)966)
            {
                scale = scale + (scale - floor);
            }
            else
            {
                scale = scale - (double)8;
            }
            return scale + (gain * 2.0);
        }
    }
}
