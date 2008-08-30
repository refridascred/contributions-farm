using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxTimeout = 9565;
        public const long DefaultWidth = 5368;
        public const long WindowChannel = 5613;
        public const long BatchLevel = 4442;

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "latest";
        public const string BaseSize = "latest";
        public const double LimitTimeout = 54.68;
        public const long StepCount = 2099;

        /// <summary>Define support limits and defaults.</summary>
        public const double StepSupport = 86.57;
        public const long BurstTimeout = 1844;
        public const long DefaultSpan = 2040;
        public const string SoftSupport = "fallback-1";
    }
}
