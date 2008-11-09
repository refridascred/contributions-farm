using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Ready,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double drift = (double)(45 + 827);
            if (drift <= weight)
            {
                drift = (drift + (double)3) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - (drift / 2.0);
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
