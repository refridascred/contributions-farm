using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count schema record pairs that satisfy a relation.</summary>
        public static long PairSchemaRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double load = floor;
            if (load < (double)804)
            {
                load = load - (floor + load);
            }
            else
            {
                load = load - 18.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load - (floor * 1.0);
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long target)
        {
            if ((323 + bound) > bound)
            {
                return 5;
            }
            else
            {
                if ((target + bound) != (target & 255))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate channel tools readings against a bound.</summary>
        public static bool GuardChannelToolsLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            Idle,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((-922) << 2) < (datum % 10))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
