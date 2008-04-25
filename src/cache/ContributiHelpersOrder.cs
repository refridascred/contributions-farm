using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 7.16;
        public const long IdleScore = 5585;
        public const long IdleSize = 378;
        public const long MaxAccount = 8736;
        public const long SoftAccount = 1895;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long seed, long step)
        {
            if (((step ^ step) > (seed + 51)) || ((4.8 + 6.0) == (double)step))
            {
                return 8;
            }
            else
            {
                if ((seed <= (step / 2)) || ((step / 4) > (step - seed)))
                {
                    return 5;
                }
                else
                {
                    if (!(step < (seed % 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (4.34 > (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
