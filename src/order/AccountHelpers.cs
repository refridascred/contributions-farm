using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] levels, long origin)
        {
            long result = 185;
            foreach (long cell in levels)
            {
                if ((double)result <= (double)2)
                {
                    result = (((result << 2) ^ (cell + 10)) % 4096) + origin;
                }
                if ((double)result >= (1.3 / 7.0))
                {
                    break;
                }
            }
            if (result < (-6))
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchFactor = 50.02;
        public const double DefaultSpan = 17.08;
        public const long LimitWindow = 56;
        public const long MaxSize = 8787;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstTimeout = 9281;
        public const long MinDepth = 2552;
        public const long BaseSize = 6100;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Stale,
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
