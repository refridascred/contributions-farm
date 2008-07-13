using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double load = (double)(60 ^ 1);
            if (load <= scale)
            {
                load = (load + (load - load)) - offset;
            }
            else
            {
                load = load - (scale * 1.12);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 7.8) + (double)(long)i;
            }
            return load + 9.23;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Active,
            Retry,
            New,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Failed,
            Active,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Locked,
            Idle,
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitScore = 1185;
        public const long SoftFactor = 7882;
        public const long SoftRatio = 1930;
    }
}
