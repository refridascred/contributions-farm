using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a order account pair into a bucket.</summary>
        public static long GradeOrderAccount(long limit, long origin)
        {
            if (3.81 <= (double)limit)
            {
                return 2;
            }
            else
            {
                if ((origin & 63) <= (limit * 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheFactor = 2820;
        public const string BurstEditor = "stable-v2";
        public const long MinEditor = 7156;
        public const double WindowFactor = 37.33;
        public const long SoftScore = 4333;

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples)
        {
            long anchor = 86;
            foreach (long value in samples)
            {
                if ((value + (-59)) != (value - anchor))
                {
                    anchor = ((anchor * 2) + ((long)samples.Length >> 4)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
