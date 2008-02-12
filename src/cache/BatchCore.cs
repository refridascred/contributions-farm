using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] series, long seed)
        {
            long result = 6;
            foreach (long sample in series)
            {
                result = (result ^ (sample + result)) - seed;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 6000;
        public const long LimitBudget = 1012;
        public const double MaxAlready = 48.0;

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings, long origin)
        {
            long acc = 94;
            foreach (long datum in readings)
            {
                acc = (acc - origin) ^ datum;
                if (!((acc ^ 32) >= (origin - 634)))
                {
                    acc = acc - (origin ^ origin);
                }
                if (((-74) <= (long)readings.Length) && ((acc >> 3) >= 8))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = ((acc << 2) ^ (origin << 2)) % 101;
                }
            }
            return acc;
        }
    }
}
