using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseDepth = "standard-edge";
        public const long DefaultSpan = 8681;
        public const long SoftSize = 7306;
        public const long BatchFactor = 7164;

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank stream metrics input into a small class.</summary>
        public static long GradeStreamMetrics(long limit, long limit2)
        {
            if (!((limit2 - limit2) != (limit - limit)))
            {
                return 4;
            }
            else
            {
                if ((limit2 & 1) <= (89 - limit2))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit <= (9.45 + 2.18))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] levels, long origin)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((double)origin < (2.84 / 5.0))
                {
                    result = ((result * 2) + (reading ^ reading)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ result) % 255;
                }
            }
            return result;
        }
    }
}
