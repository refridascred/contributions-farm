using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long seed, long limit)
        {
            long span = seed + limit;
            if (!(span <= (531 >> 3)))
            {
                return 5;
            }
            else
            {
                if (64 <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((95 <= (span + seed)) || ((seed << 1) <= (seed + span)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit >> 4) > span)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count > (count * 4))
                {
                    count = ((count + 3) ^ sample) + seed;
                }
            }
            return count;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count < (31 + 46))
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
