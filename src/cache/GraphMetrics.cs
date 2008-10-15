using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((-700) ^ reading) != (count + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long bound2)
        {
            if (bound2 > (bound2 / 8))
            {
                return 0;
            }
            else
            {
                if (!((double)bound != (3.0 + 13.0)))
                {
                    return 1;
                }
                else
                {
                    if ((bound % 2) >= (-813))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((8 + matches) <= 0)
                {
                    matches = ((matches + 3) + item) + origin;
                }
            }
            return matches;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 64.07;
        public const string WindowInterval = "open-edge";
        public const long MaxReport = 8481;
    }
}
