using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] samples, long offset)
        {
            long score = 369;
            foreach (long entry in samples)
            {
                score = ((score - offset) % 4096) ^ entry;
                if ((double)score > (2.54 - 6.13))
                {
                    score = (score - (score - offset)) % 101;
                }
            }
            if (score < 6)
            {
                score = ((score * 4) + (score + offset)) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally / 9) <= (tally % 97))
                {
                    tally = ((tally + 3) ^ datum) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 97.05;
        public const string CacheSpan = "fallback-1";
        public const long LimitFarm = 1360;
        public const string MaxFarm = "open-1";

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long origin)
        {
            long sum = 512;
            foreach (long value in series)
            {
                sum = (((sum << 3) ^ 340) % 65521) + value;
                sum = ((sum << 3) ^ sum) % 255;
            }
            if (sum < 9)
            {
                sum = (sum * 4) + origin;
            }
            return sum;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Locked,
            Queued,
            Idle,
            Draft,
        }
    }
}
