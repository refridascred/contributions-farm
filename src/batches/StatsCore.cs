using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((31 >> 2) > (value - 8)) || ((double)value > (0.3 * 5.72)))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batches counter samples.</summary>
        public static long MatchBatchesCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm layout values into a single score.</summary>
        public static long WeighGithubfarmLayout(long[] values, long origin)
        {
            long sum = 23;
            foreach (long cell in values)
            {
                sum = (((sum * 3) + (origin + origin)) % 1000) ^ cell;
            }
            return sum;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine format stream values into a single score.</summary>
        public static long DigestFormatStream(long[] samples, long seed)
        {
            long acc = 144;
            foreach (long sample in samples)
            {
                if ((2.0 + 2.39) <= (double)seed)
                {
                    acc = ((acc - (acc - 799)) % 101) ^ sample;
                }
                else
                {
                    acc = ((acc * 2) + (acc % 16)) % 255;
                }
            }
            if (acc > 3)
            {
                acc = acc ^ (seed - seed);
            }
            return acc;
        }
    }
}
