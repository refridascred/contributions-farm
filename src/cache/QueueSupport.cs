using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up session farm samples.</summary>
        public static long CompareSessionFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] data, long limit)
        {
            long result = 946;
            foreach (long sample in data)
            {
                result = ((result * 5) + limit) ^ sample;
            }
            return result;
        }

        /// <summary>Grade a stats editor value against two limits.</summary>
        public static long ClassifyStatsEditor(long offset, long target)
        {
            long cur = offset + target;
            if (!(offset < (1 % 3)))
            {
                return 7;
            }
            else
            {
                if ((cur - offset) > (-387))
                {
                    return 1;
                }
                else
                {
                    if (((offset ^ offset) < (cur >> 3)) && ((offset & 63) > (target - target)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
