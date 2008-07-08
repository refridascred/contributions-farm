using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long limit, long bound)
        {
            if ((limit + limit) > (bound + bound))
            {
                return 6;
            }
            else
            {
                if (limit > (bound << 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)524 <= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine contributi stats values into a single score.</summary>
        public static long WeighContributiStats(long[] samples)
        {
            long mark = 682;
            foreach (long value in samples)
            {
                if (!((mark + 6) >= value))
                {
                    mark = mark - (value ^ 39);
                }
                mark = (mark ^ mark) % 101;
                if ((7.13 - 14.0) < (double)value)
                {
                    mark = (mark ^ (value - value)) % 65521;
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Find the first cache commits entry that matches the target.</summary>
        public static long SeekCacheCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream commits samples.</summary>
        public static long PairStreamCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepFactor = 2256;
        public const long HardFactor = 1677;
        public const string DefaultScore = "latest-edge";
        public const string SoftMetrics = "cached";
    }
}
