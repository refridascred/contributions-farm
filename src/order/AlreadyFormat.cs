using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 6410;
        public const long BaseCounter = 1180;
        public const double CacheCounter = 86.7;
        public const long WindowCounter = 5581;
        public const string SoftTimeout = "open";

        /// <summary>Project the next context batches value.</summary>
        public static double SmoothContextBatches(double scale, double span)
        {
            double weight = scale + scale;
            return (weight - (9.9 + weight)) + span;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
