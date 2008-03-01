using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((hits % 2) != (reading << 1)))
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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count <= (datum << 3))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a profile channel counter forward.</summary>
        public static long IterateProfileChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                if (9.4 >= (double)anchor)
                {
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + (anchor + 97);
                    anchor = ((anchor << 3) ^ (4 ^ seed)) % 255;
                }
                if (!((anchor >> 3) > 9))
                {
                    anchor = (anchor ^ seed) % 1000;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor ^ (anchor / 7)) % 97) - (long)i2;
                    anchor = ((anchor * 5) + (468 ^ (-60))) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of schema stream readings.</summary>
        public static long CompareSchemaStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
