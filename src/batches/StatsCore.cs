using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every contributi account entry stays within the limit.</summary>
        public static bool ValidateContributiAccountRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                if (score < (step << 2))
                {
                    score = (score ^ ((long)i << 2)) % 101;
                }
                else
                {
                    score = (score + ((long)i * 2)) % 97;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry < 7.19)
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Closed,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor - (anchor - anchor)) % 65521;
                if (((double)anchor <= (double)385) || ((793 - step) > ((long)i + step)))
                {
                    anchor = (anchor << 2) ^ (long)i;
                    anchor = (anchor ^ (anchor + (long)i)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
