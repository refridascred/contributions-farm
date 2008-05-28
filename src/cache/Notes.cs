using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value ^ matches) >= (matches ^ value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine route session values into a single score.</summary>
        public static long DigestRouteSession(long[] readings)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = score - datum;
            }
            if (score < 271)
            {
                score = (score ^ (score << 2)) % 65521;
            }
            return score;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long bound, long bound2)
        {
            if (bound2 >= (2 >> 4))
            {
                return 7;
            }
            else
            {
                if ((12.0 / 5.0) != (double)bound2)
                {
                    return 8;
                }
                else
                {
                    if (9.89 > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count commits cluster pairs that satisfy a relation.</summary>
        public static long MatchCommitsClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
