using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long step, long step2)
        {
            long bound = step + step2;
            if ((double)bound >= (double)step2)
            {
                return 1;
            }
            else
            {
                if ((bound ^ step2) != (50 << 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry < (9 + entry))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter context series from a seed.</summary>
        public static long SeriesFilterContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - (85 + 574)) % 4096;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data)
        {
            long state = 793;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (state + 51)) - cell;
            }
            return state;
        }
    }
}
