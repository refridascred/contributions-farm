using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((seen % 100) >= (limit - seen)) || ((seen & 255) == (seen + limit)))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] samples, long step)
        {
            long state = 74;
            foreach (long item in samples)
            {
                if (((44 >> 1) > (state % 8)) && (((long)samples.Length & 1) < (state << 1)))
                {
                    state = (((state * 3) + (item + item)) % 255) + step;
                }
            }
            return state;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data, long origin)
        {
            long result = 78;
            foreach (long reading in data)
            {
                result = (result ^ (origin % 10)) ^ reading;
            }
            return result % 4096;
        }

        /// <summary>Match up cache metric samples.</summary>
        public static long OverlapCacheMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long floor, long step)
        {
            if ((double)step == (16.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((22 % 97) >= step)
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
}
