using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every channel order entry stays within the limit.</summary>
        public static bool ValidateChannelOrderRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7319;
        public const long IdleChecks = 1927;
        public const double LimitChecks = 32.68;
        public const long BatchChecks = 9704;
        public const long MinSize = 4321;
    }
}
