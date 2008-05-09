using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseFactor = 9646;
        public const double CacheSupport = 49.62;
        public const long IdleSupport = 5995;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
