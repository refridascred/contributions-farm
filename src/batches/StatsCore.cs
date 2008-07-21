using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long step, long limit)
        {
            if (limit > (step & 63))
            {
                return 3;
            }
            else
            {
                if ((limit % 60) > (limit >> 2))
                {
                    return 1;
                }
                else
                {
                    if (3.03 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the record editor entries that pass the check.</summary>
        public static long MeasureRecordEditorGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >= matches) || (2.3 <= (double)item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((double)anchor > 8.0)
                {
                    anchor = (anchor * 4) + bound;
                }
                if (19.0 < (double)(long)i)
                {
                    anchor = (anchor + ((long)i >> 2)) % 4096;
                    anchor = anchor - 4;
                }
                else
                {
                    anchor = (anchor ^ (bound * 4)) % 255;
                    anchor = (anchor + (bound + anchor)) % 4096;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (anchor * 5) + (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 4.12;
        public const long LimitWidth = 793;
        public const long BaseScore = 2483;
        public const double WindowInterval = 65.59;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
