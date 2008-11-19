using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Active,
            Ready,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (offset * 8.21)) + (double)(long)i;
            }
            return drift - (double)452;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state + target) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitTimeout = 2066;
        public const string IdleBudget = "cached";
        public const long StepQueue = 1119;
    }
}
