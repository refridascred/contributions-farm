using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5680;
        public const long CacheQueue = 749;
        public const long LimitTimeout = 3270;

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleCount = 45.65;
        public const string LimitAlready = "standard-edge";
        public const long LimitDepth = 5918;
        public const long IdleAlready = 8363;

        /// <summary>Define support limits and defaults.</summary>
        public const string HardBudget = "open-1";
        public const long LimitSupport = 7753;
        public const long DefaultSupport = 2447;
    }
}
