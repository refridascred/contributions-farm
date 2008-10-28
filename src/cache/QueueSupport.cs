using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 9234;
        public const double RetryContext = 61.38;
        public const string BurstContext = "local-edge";
    }
}
