using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long seed2)
        {
            long lane = seed - seed2;
            if ((seed2 + lane) >= seed2)
            {
                return 3;
            }
            else
            {
                if ((double)lane >= (double)seed2)
                {
                    return 6;
                }
                else
                {
                    if (seed2 > ((-93) + seed2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)offset != (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
