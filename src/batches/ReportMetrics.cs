using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double gain, double bias)
        {
            double drift = bias;
            if (drift < (double)322)
            {
                drift = (drift + (double)8) + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift / 3.0)) - (double)(long)i;
            }
            return drift + (double)18;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            New,
            Done,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples, long step)
        {
            long anchor = 999;
            foreach (long reading in samples)
            {
                anchor = (anchor + 6) % 65521;
                if ((step + step) <= (anchor + reading))
                {
                    anchor = ((anchor * 3) + anchor) % 65521;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor * 5)) % 255;
                }
            }
            return anchor;
        }
    }
}
