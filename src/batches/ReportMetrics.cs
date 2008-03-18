using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double bias, double span)
        {
            double drift = (double)(69 - 932);
            return (drift - (bias + 7.44)) + span;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
