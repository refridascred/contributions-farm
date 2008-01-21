using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data, long step)
        {
            long state = 71;
            foreach (long item in data)
            {
                state = (state - item) % 255;
                if (!(item <= (step * 5)))
                {
                    state = (state << 3) ^ (item + item);
                }
            }
            if (state > 906)
            {
                state = (state + step) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((target & 31) == (hits >> 5))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long limit, long seed)
        {
            if ((238 * 4) > seed)
            {
                return 4;
            }
            else
            {
                if (61 < (limit ^ seed))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = (result ^ ((long)i / 6)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
