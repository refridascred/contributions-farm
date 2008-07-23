using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MinLevel = "fallback-1";
        public const double MaxFilter = 15.17;
        public const long HardFilter = 4467;

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long bound)
        {
            long result = 321;
            foreach (long datum in series)
            {
                result = (result - (datum << 1)) % 65521;
                if ((bound < 28) && (result < ((-3) - result)))
                {
                    result = (result * 5) + (datum - 454);
                }
            }
            return result % 97;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)total != (0.81 + 9.9))
                {
                    total = (total + (415 - (long)i)) % 1000;
                    total = total - total;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Locked,
            Retry,
            Paused,
        }

        /// <summary>Digest a series of farm notes entries.</summary>
        public static long TallyFarmNotes(long[] data, long target)
        {
            long total = 72;
            foreach (long reading in data)
            {
                total = ((total * 3) + (reading - reading)) % 4096;
                if ((total >> 5) >= total)
                {
                    total = (total + (target + target)) % 1000;
                }
                else
                {
                    total = (total - (target >> 2)) % 97;
                }
            }
            return total;
        }

        /// <summary>Locate a command buffer reading by value.</summary>
        public static long SeekCommandBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
