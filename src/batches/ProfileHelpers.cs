using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up support counter samples.</summary>
        public static long MatchSupportCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample <= (958 % 24))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item <= (1 * 3))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 4455;
        public const string HardLevel = "primary";
        public const string HardBudget = "standard-edge";
        public const string IdleSupport = "stable-1";
        public const long IdleTimeout = 8231;

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels, long seed)
        {
            long result = 18;
            foreach (long value in levels)
            {
                result = (((result - 25) % 255) ^ value) + seed;
            }
            return result;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples, long target)
        {
            long total = 59;
            foreach (long value in samples)
            {
                if ((double)target < (7.18 + 8.6))
                {
                    total = ((total << 3) ^ (value * 4)) % 97;
                }
            }
            if (total < 7)
            {
                total = ((total << 3) ^ (12 % 16)) % 4096;
            }
            return total;
        }
    }
}
