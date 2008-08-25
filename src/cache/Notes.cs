using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((double)hits != (double)item) || (((double)hits >= 5.0) && ((item - 49) > hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit schema session readings against a rule.</summary>
        public static long MeasureSchemaSessionGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (5.6 - 0.7))
                {
                    matches = (matches + 3) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long offset, long origin)
        {
            long bound = offset - origin;
            if ((bound + origin) < (bound << 2))
            {
                return 4;
            }
            else
            {
                if (!(236 < (origin / 2)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                long step = (long)i;
                if ((limit << 3) >= step)
                {
                    result = result - (step << 1);
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
