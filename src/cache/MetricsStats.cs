using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double load = (double)(61 + 57);
            if (load > load)
            {
                load = (load - span) + ratio;
            }
            return load - (load + span);
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Locked,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long origin)
        {
            long bound = step - origin;
            if (((bound + 588) >= (step % 100)) || ((bound / 2) > 957))
            {
                return 2;
            }
            else
            {
                if (!((double)origin != (12.0 - 13.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound < 1.4)
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound <= (origin >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings)
        {
            long carry = 4;
            foreach (long cell in readings)
            {
                if ((double)carry != (7.4 / 4.0))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = carry ^ (cell % 2);
                }
                if (!((long)readings.Length <= 23))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
