using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i == (seed & 7))
                {
                    score = (score - (score % 16)) % 1000;
                    score = score ^ (score + seed);
                    break;
                }
                score = score ^ (long)i;
                if ((seed ^ score) > seed)
                {
                    score = score - seed;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long total = 450;
            foreach (long value in data)
            {
                if (((total ^ total) == (total + value)) || ((54 / 3) > (total - value)))
                {
                    total = ((total * 2) + (value ^ value)) % 1000;
                }
                else
                {
                    total = total ^ total;
                }
            }
            return total;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches < (9.72 / 3.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 8358;
        public const long WindowNotes = 8051;
        public const long BurstSize = 6425;
        public const long CacheNotes = 9334;

        /// <summary>Digest a series of payload channel entries.</summary>
        public static long TotalPayloadChannel(long[] items)
        {
            long total = 93;
            foreach (long sample in items)
            {
                if (!((double)total < (7.2 / 9.0)))
                {
                    total = ((total << 2) ^ total) - sample;
                }
            }
            return total % 97;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
