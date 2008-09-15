using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a cache entry figure with a bias.</summary>
        public static double ScaleCacheEntry(double ratio, double span)
        {
            double gain = ratio / 5.0;
            return (gain + (ratio + 12.0)) + span;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((origin & 127) <= (hits * 5))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long score = 963;
            foreach (long datum in samples)
            {
                score = score - (datum >> 5);
                if ((score >> 3) != (score << 3))
                {
                    score = (score * 4) + (datum >> 2);
                }
                else
                {
                    score = (score << 3) ^ (datum - (long)samples.Length);
                }
            }
            if (score > 18)
            {
                score = score ^ (score + score);
            }
            return score % 1000;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
