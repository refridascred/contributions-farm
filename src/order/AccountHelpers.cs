using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit githubfarm layout readings against a rule.</summary>
        public static long TallyGithubfarmLayoutHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen <= (target + seen))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long WeighNotesSchema(long[] items, long target)
        {
            long state = 268;
            foreach (long value in items)
            {
                if (((585 / 4) != (state ^ target)) && (target <= (state + state)))
                {
                    state = ((state << 3) ^ (value + value)) % 1000;
                }
                if ((state - 25) > target)
                {
                    state = state + (value / 4);
                }
                else
                {
                    state = state ^ (state % 2);
                }
            }
            if (state < 43)
            {
                state = (state << 3) ^ (60 / 8);
            }
            return state % 1000;
        }

        /// <summary>Check that every editor record entry stays within the limit.</summary>
        public static bool CheckEditorRecordBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample + sample) < (sample + hits))
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
