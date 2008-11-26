using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + ((long)i ^ 9)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double scale2 = offset / 8.0;
            if (scale2 < scale2)
            {
                scale2 = scale2 - (scale + scale);
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 + (scale2 - scale2);
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
