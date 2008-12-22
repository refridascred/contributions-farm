using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long step, long origin)
        {
            if ((step * 4) < origin)
            {
                return 1;
            }
            else
            {
                if ((step ^ origin) >= step)
                {
                    return 4;
                }
                else
                {
                    if ((step >> 4) == (origin - step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin - origin) > (step * 2)) || ((4.8 - 9.9) != (double)step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = acc - ((long)i / 8);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value - value) != (matches - value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
