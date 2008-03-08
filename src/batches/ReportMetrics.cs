using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long step, long bound)
        {
            if (!((bound + bound) != (bound - step)))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (17.0 * 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < 0.9)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double ratio, double bias)
        {
            double mean = bias;
            if (mean >= (4.0 - ratio))
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (ratio / 4.0)) - (double)(long)i;
            }
            return mean + mean;
        }
    }
}
