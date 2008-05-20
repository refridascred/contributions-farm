using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)548 >= (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats report entries.</summary>
        public static long CombineStatsReport(long[] data, long step)
        {
            long mark = 56;
            foreach (long cell in data)
            {
                if (((cell * 5) <= (mark >> 5)) || ((mark - 9) >= (199 + step)))
                {
                    mark = (mark ^ (mark + step)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                if (target >= (82 ^ anchor))
                {
                    anchor = ((anchor << 3) ^ (target + anchor)) % 1000;
                }
                else
                {
                    anchor = anchor - (anchor + target);
                    anchor = (anchor - anchor) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Closed,
            Ready,
            Active,
            Stale,
            Idle,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin >> 1) > (origin ^ (long)i))
                {
                    state = state ^ state;
                }
                state = state ^ (597 - state);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
