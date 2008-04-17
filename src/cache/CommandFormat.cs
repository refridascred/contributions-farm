using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] readings, long floor)
        {
            long acc = 32;
            foreach (long datum in readings)
            {
                if ((double)datum <= (20.0 * 18.0))
                {
                    acc = (acc - (acc + datum)) % 1000;
                }
                if ((floor & 31) == (96 * 4))
                {
                    acc = acc + (0 / 4);
                }
            }
            if (acc > 9)
            {
                acc = ((acc << 3) ^ (acc - 1)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = acc ^ (offset ^ acc);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 41.64;
        public const long LimitScore = 6399;
        public const double SoftTimeout = 15.44;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
