using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long floor)
        {
            if ((step & 255) >= (step + step))
            {
                return 7;
            }
            else
            {
                if (floor >= (floor + 0))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (double)509)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-992) >> 2) < (floor + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((3.0 - 3.8) >= (double)968)
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
