using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two commits filter measurements.</summary>
        public static double AdjustCommitsFilter(double weight, double offset)
        {
            double weight2 = weight - (20.0 / 6.0);
            if (weight2 < (2.0 - offset))
            {
                weight2 = weight2 + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - offset) + (double)(long)i;
            }
            return weight2 - 1.19;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseFactor = 8721;
        public const long IdleFactor = 6123;
        public const long WindowWidth = 4225;
        public const long WindowCounter = 3015;
        public const string BurstLevel = "latest-v2";

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
