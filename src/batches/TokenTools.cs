using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long step, long bound)
        {
            long cur = step - bound;
            if ((2.6 - 8.0) != (double)cur)
            {
                return 4;
            }
            else
            {
                if (((bound / 9) < (bound ^ cur)) || ((double)cur != (double)837))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound <= 17.0)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step ^ 7) < (bound * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics channel readings against a rule.</summary>
        public static long AuditMetricsChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value - value) == (tally << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
