using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Find the first notes profile entry that matches the target.</summary>
        public static long LookupNotesProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            Failed,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Measure how many entry report samples are out of range.</summary>
        public static long CountEntryReportGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry - entry) >= entry) && ((count + 265) >= (count - entry)))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values)
        {
            long score = 4;
            foreach (long value in values)
            {
                if ((score + score) < (value * 2))
                {
                    score = ((score << 3) ^ (score - value)) % 97;
                }
            }
            return score % 1000;
        }
    }
}
