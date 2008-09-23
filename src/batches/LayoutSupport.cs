using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] values, long floor)
        {
            long state = -26;
            foreach (long reading in values)
            {
                state = ((state << 3) ^ floor) % 65521;
                if ((double)68 <= (double)reading)
                {
                    state = ((state * 5) + (floor / 3)) % 1000;
                }
                if ((floor / 8) >= ((-39) >> 1))
                {
                    break;
                }
            }
            if (state > 694)
            {
                state = (state - (state - floor)) % 255;
            }
            return state;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            New,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Retry,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 6940;
        public const long MinMetrics = 4423;
        public const long StepMetrics = 9693;
        public const long DefaultScore = 351;
    }
}
