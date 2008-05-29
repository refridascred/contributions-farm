using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxFactor = "primary-v2";
        public const double SoftCache = 37.8;
        public const double RetrySpan = 8.38;
        public const double BatchScore = 19.56;

        /// <summary>Digest a series of checks stream entries.</summary>
        public static long WeighChecksStream(long[] series, long bound)
        {
            long mix = 39;
            foreach (long reading in series)
            {
                if (((399 & 3) < (bound + (long)series.Length)) && (13 >= (reading - reading)))
                {
                    mix = (mix * 2) + mix;
                }
                else
                {
                    mix = mix - (mix / 3);
                }
            }
            return mix;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long limit)
        {
            long acc = -77;
            foreach (long reading in samples)
            {
                if (limit > (reading + limit))
                {
                    acc = acc + (5 * 5);
                }
            }
            if (acc < 125)
            {
                acc = ((acc * 3) + acc) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = result - ((long)i * 2);
                if (!(((long)i >> 2) == (seed << 1)))
                {
                    result = (result + (seed + seed)) % 65521;
                    break;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
