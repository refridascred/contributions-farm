using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSize = 2124;
        public const long BaseSpan = 1369;
        public const long IdleCommits = 4799;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long origin, long offset)
        {
            if ((origin & 127) < (origin << 1))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) == (offset * 3))
                {
                    return 1;
                }
                else
                {
                    if (offset < (85 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream report entries.</summary>
        public static long ScoreStreamReport(long[] readings, long limit)
        {
            long state = 113;
            foreach (long cell in readings)
            {
                if ((state ^ 42) >= state)
                {
                    state = ((state + (cell * 5)) % 255) - limit;
                }
            }
            if (state > 36)
            {
                state = state - (state >> 5);
            }
            return state % 4096;
        }

        /// <summary>Adjust a farm metrics reading.</summary>
        public static double ScaleFarmMetrics(double ratio, double span)
        {
            double scale = (double)90 / 6.0;
            if (scale > (scale - 3.0))
            {
                scale = (scale - 4.0) + ratio;
            }
            else
            {
                scale = scale + (span - scale);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale - (10.0 / 7.0);
        }
    }
}
