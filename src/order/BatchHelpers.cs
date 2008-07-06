using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a metric stream value against two limits.</summary>
        public static long ClassifyMetricStream(long origin, long seed)
        {
            if ((origin << 2) > origin)
            {
                return 7;
            }
            else
            {
                if ((origin + origin) > (origin * 5))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long offset)
        {
            if ((offset * 5) <= step)
            {
                return 3;
            }
            else
            {
                if (offset >= 85)
                {
                    return 5;
                }
                else
                {
                    if ((19.0 / 9.0) >= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up tools batches samples.</summary>
        public static long PairToolsBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
