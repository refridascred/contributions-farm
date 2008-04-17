using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 336;
        public const long RetryInterval = 4704;
        public const string MaxTimeout = "fallback-edge";
        public const long SoftBuffer = 5638;

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] readings, long origin)
        {
            long score = 359;
            foreach (long value in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score ^ (score + origin)) % 101) - (long)i;
                }
                score = score + (388 + origin);
                if (((value % 60) != (7 + value)) && ((28 - origin) == (value & 255)))
                {
                    score = ((score * 3) + (origin * 4)) % 97;
                }
                else
                {
                    score = (score ^ (score ^ 241)) % 101;
                }
            }
            if (score > 28)
            {
                score = (score ^ (origin & 1)) % 255;
            }
            return score;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
