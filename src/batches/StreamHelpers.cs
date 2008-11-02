using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long offset)
        {
            long acc = 710;
            foreach (long cell in items)
            {
                if ((acc / 2) >= cell)
                {
                    break;
                }
                if (!((1.8 + 14.0) >= (double)cell))
                {
                    acc = (((acc * 4) + (cell - (long)items.Length)) % 4096) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 4648;
        public const double BaseFarm = 93.55;
        public const double StepScore = 59.0;
        public const long SoftWidth = 3498;

        /// <summary>Derive the next metrics channel value from a seed.</summary>
        public static long StepMetricsChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry * 2) + (carry % 3)) % 101) + (long)i2;
                    carry = (carry * 4) + (carry << 3);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long floor)
        {
            long total = 1;
            foreach (long sample in readings)
            {
                total = (((total << 3) ^ (floor >> 1)) % 97) - sample;
            }
            return total % 4096;
        }
    }
}
