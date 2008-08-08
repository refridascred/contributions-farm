using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long step, long limit)
        {
            if (((-28) + step) == (step + limit))
            {
                return 6;
            }
            else
            {
                if ((limit % 3) >= (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((step - limit) >= (step >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] series, long seed)
        {
            long sum = -523;
            foreach (long cell in series)
            {
                sum = (((sum << 2) ^ 6) ^ cell) - seed;
            }
            return sum;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (7.8 <= (double)seen)
                {
                    seen = ((seen + 2) + entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)step < (20.0 * 5.46)) || !(step > sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
