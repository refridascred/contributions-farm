using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 51.21;
        public const long LimitRatio = 6800;
        public const long MaxLevel = 561;
        public const long BaseChecks = 9051;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
