using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)target > (6.84 - 9.01))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "cached";
        public const string DefaultLevel = "local";
        public const string LimitCount = "legacy";

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long limit, long bound)
        {
            if ((bound < (bound * 5)) && ((bound + limit) != (limit & 127)))
            {
                return 1;
            }
            else
            {
                if ((double)bound > (16.0 + 5.3))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
