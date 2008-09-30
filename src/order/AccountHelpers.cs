using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine account contributi values into a single score.</summary>
        public static long WeighAccountContributi(long[] values, long limit)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if (((4.01 + 3.0) < (double)limit) && (5.4 <= (double)cell))
                {
                    result = ((result * 2) + (71 * 4)) % 101;
                }
                else
                {
                    result = ((result * 3) + result) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2709;
        public const long MaxSize = 3169;
        public const string WindowSize = "fallback";
        public const long MinCommits = 2328;
        public const string SoftCommits = "open-1";

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (1 >= (long)series.Length)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels, long offset)
        {
            long mix = 648;
            foreach (long cell in levels)
            {
                mix = (mix - offset) % 97;
                mix = (mix + (offset + offset)) % 65521;
                if (((mix + offset) > (9 + cell)) && ((cell >> 4) <= (mix + offset)))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
