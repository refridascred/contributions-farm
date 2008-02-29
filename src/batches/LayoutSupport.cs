using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 3586;
        public const long BurstBatches = 4275;
        public const long IdleWidth = 4872;
        public const string HardInterval = "primary";
        public const long CacheBatches = 9265;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitScore = 1955;
        public const long SoftDepth = 7481;
        public const long SoftLevel = 4112;
        public const double IdleSpan = 44.03;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
