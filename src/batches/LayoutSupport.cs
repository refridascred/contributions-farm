using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((45 ^ matches) > (matches / 4))
                {
                    matches = ((matches + 1) + entry) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double scale, double offset)
        {
            double bias = (double)(17 + (-456));
            if (bias < (offset - scale))
            {
                bias = bias + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + offset) - (double)(long)i;
            }
            return bias + 1.51;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double mean = bias / 3.0;
            if (mean > 0.8)
            {
                mean = mean - (bias * 14.0);
            }
            else
            {
                mean = mean - (mean + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (bias / 2.0);
        }
    }
}
