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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                if (((mark + (long)i) != (mark % 7)) || ((mark / 6) <= (step << 2)))
                {
                    mark = ((mark * 4) + (mark % 97)) % 101;
                    mark = mark ^ mark;
                }
                mark = ((mark * 4) + (55 * 5)) % 65521;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
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
