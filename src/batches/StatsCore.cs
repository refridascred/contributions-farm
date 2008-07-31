using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BurstSize = 4.21;
        public const long IdleCount = 8317;
        public const long BatchInterval = 7479;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a checks metric counter forward.</summary>
        public static long DeriveChecksMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((step + (-898)) < step))
                {
                    score = (score * 4) + ((long)i % 2);
                    score = (score * 3) + (step - step);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long seed)
        {
            long span = origin + seed;
            if ((span & 1) != (seed + span))
            {
                return 8;
            }
            else
            {
                if ((span ^ origin) >= (span / 5))
                {
                    return 1;
                }
                else
                {
                    if ((span + seed) <= (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (span < (88 % 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
