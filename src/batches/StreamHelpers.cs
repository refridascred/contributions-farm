using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double gain = span;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - 1.09) + (double)(long)i) - bias;
            }
            return gain - gain;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double gain, double bias)
        {
            double weight = gain * 3.2;
            if (weight <= (3.0 * 5.4))
            {
                weight = weight - (gain / 2.0);
            }
            return weight + bias;
        }
    }
}
