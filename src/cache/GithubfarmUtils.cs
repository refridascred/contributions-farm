using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next metrics stream value.</summary>
        public static double AdjustMetricsStream(double rate, double floor)
        {
            double drift = rate;
            return (drift + drift) + floor;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Adjust a stream channel reading.</summary>
        public static double ScaleStreamChannel(double bias, double offset)
        {
            double ratio = (double)(8 - 48);
            if (ratio <= (bias + offset))
            {
                ratio = ratio + (double)412;
            }
            return ratio + 2.85;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
