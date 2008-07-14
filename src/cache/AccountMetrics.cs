using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a token counter pair into a bucket.</summary>
        public static long GradeTokenCounter(long offset, long limit)
        {
            if ((limit + limit) >= limit)
            {
                return 4;
            }
            else
            {
                if (((-223) + offset) <= ((-37) + limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit & 127) > (limit >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double ratio = (double)(88 - 798);
            if (ratio < rate)
            {
                ratio = (ratio - (rate + rate)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (7.93 * 6.9);
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((bound * 2) <= (matches - matches)) || ((reading > (0 / 4)) && ((double)matches >= (double)bound)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] data, long step)
        {
            long anchor = -77;
            foreach (long reading in data)
            {
                if (anchor <= (step / 9))
                {
                    anchor = anchor - (reading % 64);
                }
                else
                {
                    anchor = anchor - step;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many cluster checks samples are out of range.</summary>
        public static long AuditClusterChecksHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches >> 2) == (57 - matches))
                {
                    matches = ((matches + 3) - entry) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheSpan = 11.32;
        public const long MaxBudget = 6382;
        public const long DefaultCount = 7039;
        public const long BatchBuffer = 1366;
    }
}
