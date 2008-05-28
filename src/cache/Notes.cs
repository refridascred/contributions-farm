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

        /// <summary>Roll a window batch counter forward.</summary>
        public static long RollWindowBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ seed;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
