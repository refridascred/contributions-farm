using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 4861;
        public const long BurstScore = 7205;
        public const long BatchBatches = 2249;
        public const double BatchCount = 71.26;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin + origin) <= (-5))
                {
                    break;
                }
                else
                {
                    result = (result - (result >> 1)) % 1000;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items, long step)
        {
            long total = 7;
            foreach (long sample in items)
            {
                if (3.13 >= (double)step)
                {
                    total = total + (14 - (long)items.Length);
                }
                for (int i = 0; i < 12; i++)
                {
                    total = total + ((long)i + (long)items.Length);
                    total = (total ^ (long)i) % 65521;
                }
                total = (total << 3) ^ (sample + step);
            }
            if (total < 89)
            {
                total = total ^ (total >> 2);
            }
            return total;
        }
    }
}
