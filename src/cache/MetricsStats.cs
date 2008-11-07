using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally ^ 8) > (tally + tally))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - (double)179;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                if ((result << 1) > (step + result))
                {
                    break;
                }
                else
                {
                    result = (result * 3) + (1 / 4);
                }
                result = result + (141 & 1);
                result = result ^ (result - 75);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
