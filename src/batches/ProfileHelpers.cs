using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = (state + ((long)i - state)) % 97;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardSpan = "latest-1";
        public const long IdleInterval = 2539;
        public const double DefaultProfile = 19.56;
        public const long StepProfile = 9667;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Ready,
            Failed,
            Draft,
        }
    }
}
