using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor - (anchor * 3)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches ^ sample) != (matches << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long origin)
        {
            long diff = floor - origin;
            if (((double)diff >= (7.0 / 7.0)) && ((diff << 2) > floor))
            {
                return 8;
            }
            else
            {
                if ((double)origin > (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (((0.1 - 11.0) >= (double)floor) && (origin > (diff + 36)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
