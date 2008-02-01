using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of report tools readings.</summary>
        public static long WeighReportTools(long[] data, long target)
        {
            long carry = 413;
            foreach (long sample in data)
            {
                carry = ((carry + (target >> 2)) % 255) - sample;
                carry = ((carry * 2) + carry) % 255;
                carry = (carry ^ (444 / 5)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 4947;
        public const long StepRecord = 997;
        public const double MaxInterval = 42.78;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = mark ^ (mark / 6);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark ^ (mark * 4)) % 97) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
