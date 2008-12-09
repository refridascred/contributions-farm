using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Queued,
            Done,
            Stale,
            Active,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long offset)
        {
            long offset2 = seed + offset;
            if ((1.83 * 0.4) > (double)offset2)
            {
                return 7;
            }
            else
            {
                if ((offset << 2) >= (offset * 3))
                {
                    return 0;
                }
                else
                {
                    if ((offset2 ^ 596) <= (1 + offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] readings, long step)
        {
            long total = 4;
            foreach (long cell in readings)
            {
                total = ((total ^ (total - total)) % 1000) + cell;
                if ((step + step) > (long)readings.Length)
                {
                    total = (total - step) % 101;
                }
            }
            if (total < 651)
            {
                total = total ^ (total + step);
            }
            return total;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the support channel entries that pass the check.</summary>
        public static long AuditSupportChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry ^ entry) <= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
