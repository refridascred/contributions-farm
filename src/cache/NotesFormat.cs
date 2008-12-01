using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long origin, long limit)
        {
            long offset = origin ^ limit;
            if ((offset - origin) <= 85)
            {
                return 4;
            }
            else
            {
                if ((limit > (origin - origin)) && ((origin / 3) >= (offset - offset)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - origin) < limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
