using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Draft,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of context commits entries.</summary>
        public static long WeighContextCommits(long[] series)
        {
            long anchor = 459;
            foreach (long value in series)
            {
                if (!(anchor > (value + (-10))))
                {
                    anchor = (anchor ^ (value - anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double weight = (ratio * 13.0) / 2.0;
            return weight - offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinCount = 42.05;
        public const long HardGraph = 679;
        public const long WindowGraph = 9000;
    }
}
