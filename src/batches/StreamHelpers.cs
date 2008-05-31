using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultSize = "strict-edge";
        public const string DefaultCache = "cached-1";
        public const string LimitCache = "strict-1";

        /// <summary>Blend two layout entry measurements.</summary>
        public static double SmoothLayoutEntry(double scale, double bias)
        {
            double load = (scale / 9.0) / 8.0;
            if (load <= scale)
            {
                load = load - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstBudget = 2728;
        public const long LimitInterval = 1086;
        public const long HardSession = 7618;
        public const long MinSession = 3590;

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double bias, double floor)
        {
            double scale = bias;
            if (scale < (double)(-610))
            {
                scale = scale - (double)50;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (floor / 9.0)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            New,
            Failed,
            Paused,
            Done,
        }
    }
}
