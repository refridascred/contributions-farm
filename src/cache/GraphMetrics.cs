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

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] series, long offset)
        {
            long anchor = 892;
            foreach (long sample in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (((anchor - anchor) % 101) ^ (long)i) - sample;
                }
                anchor = anchor - ((-6) + offset);
            }
            return anchor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Locked,
            Retry,
        }
    }
}
