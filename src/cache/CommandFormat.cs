using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count record command pairs that satisfy a relation.</summary>
        public static long CompareRecordCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long bound)
        {
            long diff = step ^ bound;
            if ((step + diff) > bound)
            {
                return 5;
            }
            else
            {
                if ((diff + step) <= diff)
                {
                    return 7;
                }
                else
                {
                    if ((bound + step) == (step + diff))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
