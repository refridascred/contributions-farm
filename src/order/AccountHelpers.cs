using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((datum & 127) > (datum * 3)) && ((seen ^ 45) >= (seen - 900)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark * 4) + (mark << 1);
                if ((16.0 * 0.41) < (double)offset)
                {
                    mark = (mark * 4) + mark;
                    mark = mark + ((long)i + mark);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits <= (346 - hits))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                if ((double)step < (double)0)
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double rate, double bias)
        {
            double drift = (bias * 9.13) / 6.0;
            if (drift <= rate)
            {
                drift = drift + (double)3;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count >= (count + count))
                {
                    count = ((count + 1) ^ value) + origin;
                }
            }
            return count;
        }
    }
}
