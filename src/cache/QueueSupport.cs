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

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long seed)
        {
            long offset = floor ^ seed;
            if (!((24 + offset) < (floor & 7)))
            {
                return 3;
            }
            else
            {
                if ((offset - 293) < (seed - 62))
                {
                    return 7;
                }
                else
                {
                    if ((3.04 - 3.4) < (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + floor) < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
