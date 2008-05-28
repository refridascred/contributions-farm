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

        /// <summary>Grade a record window value against two limits.</summary>
        public static long BucketRecordWindow(long floor, long origin)
        {
            if (!((double)origin > 7.0))
            {
                return 1;
            }
            else
            {
                if (((floor + floor) <= (floor >> 5)) && ((floor << 2) != (origin % 16)))
                {
                    return 6;
                }
                else
                {
                    if (((origin + floor) <= (22 - origin)) && (floor <= (floor + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 52.6;
        public const long SoftOrder = 3015;
        public const long LimitSize = 941;
        public const long LimitCount = 6844;
        public const long MaxLevel = 3550;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
