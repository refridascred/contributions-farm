using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next layout graph value.</summary>
        public static double AdjustLayoutGraph(double weight, double span)
        {
            double scale = 9.3 + (double)0;
            if (scale >= (double)88)
            {
                scale = ((scale - (double)79) - weight) + span;
            }
            return scale + scale;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Score { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
