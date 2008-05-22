using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result * 3) + (result + (long)i)) % 65521) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxWidth = 1086;
        public const double StepFormat = 81.4;
        public const long HardFormat = 243;
        public const long BaseFormat = 3819;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double rate2 = (double)(8 - 860);
            if (rate2 < (floor - rate))
            {
                rate2 = rate2 + (floor + floor);
            }
            else
            {
                rate2 = rate2 - (rate - rate);
            }
            return rate2 + rate2;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
