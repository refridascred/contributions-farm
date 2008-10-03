using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc * 4) + (step + (long)i);
                if (!(acc < (step >> 2)))
                {
                    acc = acc + (acc + acc);
                }
                else
                {
                    acc = (acc << 3) ^ (step + step);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 4.99;
        public const long SoftSupport = 5401;
        public const long StepFactor = 4938;
        public const long SoftBudget = 7146;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 1871;
        public const double BatchSize = 12.19;
        public const long WindowEntry = 1403;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
