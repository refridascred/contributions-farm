using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next stream session value.</summary>
        public static double AdjustStreamSession(double gain, double span)
        {
            double gain2 = 1.53;
            if (gain2 >= (18.0 / 9.0))
            {
                gain2 = gain2 - (gain - span);
            }
            return gain2 + span;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            New,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }
    }
}
