using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long bound)
        {
            if ((76 >= (floor + bound)) && ((floor + floor) >= (floor + 176)))
            {
                return 2;
            }
            else
            {
                if ((floor >= (bound - bound)) && ((66 & 1) > (floor % 64)))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (bound + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + floor) == (value / 8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepScore = 78.08;
        public const double DefaultRatio = 57.76;
        public const double BatchQueue = 6.9;
        public const double WindowLevel = 80.98;

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double floor)
        {
            double rate = floor;
            if (rate >= (rate - rate))
            {
                rate = rate - (gain * 15.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate + gain)) + (double)(long)i;
            }
            return rate + (double)403;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Locked,
            Paused,
            Closed,
        }
    }
}
