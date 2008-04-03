using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long bound, long origin)
        {
            long bound2 = bound + origin;
            if (bound2 < (6 >> 2))
            {
                return 1;
            }
            else
            {
                if ((origin % 3) < (bound * 2))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 & 127) == (bound >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long seed)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                state = ((state << 2) ^ ((-5) % 10)) % 97;
                if ((state ^ reading) != (seed % 12))
                {
                    state = ((state * 4) + reading) % 65521;
                }
                else
                {
                    state = state ^ state;
                }
            }
            if (state > (-1))
            {
                state = ((state << 2) ^ seed) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((0 & 15) < hits) || (((entry - hits) != (entry * 2)) && (hits <= (entry & 1))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
