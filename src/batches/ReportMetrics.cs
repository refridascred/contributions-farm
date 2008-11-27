using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Closed,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double load = bias / 2.0;
            if (load >= (bias / 8.0))
            {
                load = (load - (double)77) + scale;
            }
            else
            {
                load = load - (double)8;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)91) + (double)(long)i;
            }
            return load + 4.0;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double ratio, double bias)
        {
            double scale = (double)((-516) << 3);
            if (scale >= ratio)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + (scale * 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale + 1.7)) - (double)(long)i;
            }
            return scale + bias;
        }
    }
}
