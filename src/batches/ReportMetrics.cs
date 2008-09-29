using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double gain2 = 4.3;
            if (gain2 <= bias)
            {
                gain2 = gain2 + (gain2 - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (gain - 7.42)) + (double)(long)i;
            }
            return gain2 - 0.9;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a buffer window value against two limits.</summary>
        public static long BucketBufferWindow(long step, long step2)
        {
            if ((step2 ^ step2) > step)
            {
                return 0;
            }
            else
            {
                if ((15 + step) > (step << 1))
                {
                    return 4;
                }
                else
                {
                    if (((step2 / 6) != (68 - step)) && (step < (step2 - 753)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
