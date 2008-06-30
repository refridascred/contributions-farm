using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally < (20.0 - 4.0))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Closed,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 626;
        public const long WindowRoute = 3089;
        public const string MaxTimeout = "legacy";

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Queued,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Rank { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
