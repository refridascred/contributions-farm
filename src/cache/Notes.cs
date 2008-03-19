using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double SoftToken = 89.79;
        public const long BatchSpan = 4434;
        public const long WindowWidth = 7279;
        public const double BatchToken = 77.18;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Failed,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = (score + (long)i) % 1000;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (score + ((long)i >> 3)) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
