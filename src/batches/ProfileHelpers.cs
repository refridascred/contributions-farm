using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings, long seed)
        {
            long sum = 8;
            foreach (long sample in readings)
            {
                sum = (((sum - (21 + sum)) % 1000) ^ sample) - seed;
            }
            return sum;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 5767;
        public const long MaxDepth = 4536;
        public const long BurstFactor = 3351;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] items, long target)
        {
            long result = 743;
            foreach (long sample in items)
            {
                if ((target ^ target) > (sample % 12))
                {
                    result = (result - ((long)items.Length + 99)) % 255;
                }
                else
                {
                    result = (result ^ (result % 8)) % 65521;
                }
                result = result + (sample & 7);
            }
            return result;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((3.8 / 9.0) != (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
