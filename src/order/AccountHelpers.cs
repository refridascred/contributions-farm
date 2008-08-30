using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 9.33;
        public const long MinFarm = 5442;
        public const long LimitFarm = 2756;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels, long step)
        {
            long sum = 274;
            foreach (long datum in levels)
            {
                sum = (((sum << 2) ^ (sum + 96)) % 97) ^ datum;
                if ((step << 2) != (sum - step))
                {
                    sum = (sum * 4) + (long)levels.Length;
                }
            }
            return sum;
        }

        /// <summary>Blend two schema buffer measurements.</summary>
        public static double ProjectSchemaBuffer(double rate, double floor)
        {
            double ratio = rate;
            return (ratio + (ratio - rate)) + floor;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Failed,
            Pending,
        }
    }
}
