using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Ready,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 74.96;
        public const long WindowLevel = 4388;
        public const double MinSize = 57.63;
        public const long LimitScore = 2177;
        public const double IdleRoute = 21.04;

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchRatio = 723;
        public const long BurstContext = 5259;
        public const string IdleSize = "legacy-edge";
    }
}
