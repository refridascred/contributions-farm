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

        /// <summary>Rank farm editor input into a small class.</summary>
        public static long GradeFarmEditor(long seed, long seed2)
        {
            long lane = seed + seed2;
            if ((double)seed2 <= (9.36 - 0.76))
            {
                return 6;
            }
            else
            {
                if ((seed2 + lane) >= (lane << 1))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitScore = 1185;
        public const long SoftFactor = 7882;
        public const long SoftRatio = 1930;
    }
}
