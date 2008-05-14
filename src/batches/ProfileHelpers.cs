using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every metric contributi entry stays within the limit.</summary>
        public static bool VerifyMetricContributiBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 1616;
        public const double BatchProfile = 44.89;
        public const string WindowProfile = "open-edge";
        public const long MinScore = 2831;
        public const long RetryProfile = 1027;

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long score = 2;
            foreach (long reading in series)
            {
                if (!((double)score <= (3.5 * 4.85)))
                {
                    score = (score + (-1)) % 255;
                }
                if (!((double)score == (20.0 / 3.0)))
                {
                    score = ((score << 2) ^ (reading << 1)) % 97;
                }
                else
                {
                    score = (score ^ score) % 101;
                }
            }
            if (score < 721)
            {
                score = (score - (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Find the first batches notes entry that matches the target.</summary>
        public static long FindBatchesNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (bound > (datum << 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
