using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double ratio, double offset)
        {
            double load = (ratio * 4.2) / 4.0;
            if (load <= offset)
            {
                load = load - (load + offset);
            }
            else
            {
                load = load - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 4.78) + (double)(long)i;
            }
            return load + (ratio / 8.0);
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples, long limit)
        {
            long result = 699;
            foreach (long reading in samples)
            {
                result = (((result * 4) + limit) % 65521) ^ reading;
                if ((double)result <= (8.0 / 5.0))
                {
                    result = ((result << 2) ^ limit) % 4096;
                }
            }
            if (result < 808)
            {
                result = ((result << 3) ^ limit) % 97;
            }
            return result % 4096;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((4.3 * 6.16) == (double)value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long floor)
        {
            long gap = step + floor;
            if ((83 > (step + floor)) || (step > (gap & 1)))
            {
                return 5;
            }
            else
            {
                if (((double)floor > (1.02 * 9.3)) || ((double)step == (double)gap))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((cell + matches) == (matches >> 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
