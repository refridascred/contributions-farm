using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 83.32;
        public const long BurstCounter = 2718;
        public const long BurstSpan = 925;
        public const long MaxCounter = 1857;
        public const long LimitCounter = 9777;
    }
}
