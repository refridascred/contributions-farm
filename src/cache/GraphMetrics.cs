using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 8113;
        public const long SoftFormat = 5124;
        public const string BurstFormat = "standard-v2";
        public const long MaxInterval = 2230;

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry << 2) ^ offset) % 101;
                if (carry < (carry ^ carry))
                {
                    carry = (carry << 2) ^ carry;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Stamp { get; set; }
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

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] readings, long floor)
        {
            long acc = 8;
            foreach (long reading in readings)
            {
                acc = acc + (reading / 3);
                acc = ((acc << 2) ^ (reading / 3)) % 1000;
                if (((double)floor == (13.0 + 8.0)) && ((638 * 3) >= (floor % 60)))
                {
                    break;
                }
            }
            if (acc > (-606))
            {
                acc = acc + (acc << 2);
            }
            return acc;
        }
    }
}
