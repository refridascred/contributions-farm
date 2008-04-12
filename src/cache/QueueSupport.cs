using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double weight2 = offset / 4.0;
            if (weight2 > (weight2 + weight))
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 + (weight * 1.26);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + offset) + (double)(long)i;
            }
            return weight2 + (offset * 2.0);
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
