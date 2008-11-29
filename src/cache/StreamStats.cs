using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long floor)
        {
            if (floor >= (step - step))
            {
                return 0;
            }
            else
            {
                if ((step > (step * 3)) && ((step ^ step) > 230))
                {
                    return 8;
                }
                else
                {
                    if ((489 / 5) == (floor + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate queue schema readings against a bound.</summary>
        public static bool CheckQueueSchemaLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples)
        {
            long result = 210;
            foreach (long item in samples)
            {
                if (result >= item)
                {
                    result = result + (item >> 5);
                }
            }
            if (result > 428)
            {
                result = (result << 3) ^ 34;
            }
            return result % 4096;
        }
    }
}
