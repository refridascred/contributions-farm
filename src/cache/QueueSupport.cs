using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long bound)
        {
            long delta = limit - bound;
            if ((delta % 8) < (limit >> 1))
            {
                return 1;
            }
            else
            {
                if (((-158) + bound) < (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if (65 <= (bound - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((34 << 1) > (bound / 9))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long target)
        {
            long mix = 45;
            foreach (long entry in readings)
            {
                if ((double)mix == (double)target)
                {
                    mix = (mix ^ (entry * 4)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of already metrics readings.</summary>
        public static long CompareAlreadyMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
