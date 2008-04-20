using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long step)
        {
            if ((double)step == (double)target)
            {
                return 7;
            }
            else
            {
                if (((double)step != (double)target) || ((target << 2) != (target & 63)))
                {
                    return 3;
                }
                else
                {
                    if ((double)target > (18.0 / 9.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "legacy-1";
        public const double BaseTimeout = 55.77;
        public const long WindowReport = 8245;
    }
}
