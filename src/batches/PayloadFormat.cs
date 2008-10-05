using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] data, long seed)
        {
            long result = 993;
            foreach (long reading in data)
            {
                if (result > reading)
                {
                    result = (result - (reading - reading)) - seed;
                }
                else
                {
                    result = ((result << 3) ^ (370 ^ 1)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long seed2)
        {
            if (!((7.42 - 2.03) >= (double)seed2))
            {
                return 2;
            }
            else
            {
                if ((seed2 + seed) >= (seed2 >> 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
