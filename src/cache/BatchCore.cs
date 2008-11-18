using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double bias, double bias2)
        {
            double load = (double)0 - (double)0;
            if (load >= load)
            {
                load = load - (double)8;
            }
            else
            {
                load = load - (double)93;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - bias2) - (double)(long)i;
            }
            return load + (load + bias);
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings, long limit)
        {
            long state = 4;
            foreach (long item in readings)
            {
                state = state - (item / 2);
                if (!(396 > limit))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = (state * 5) + (limit / 7);
            }
            return state % 97;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
