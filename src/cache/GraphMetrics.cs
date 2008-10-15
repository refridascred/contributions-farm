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

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] series, long step)
        {
            long mix = -6;
            foreach (long sample in series)
            {
                if ((15.0 > (5.77 + 9.78)) && ((mix - step) >= (step - sample)))
                {
                    mix = (mix * 2) + step;
                }
            }
            return mix % 4096;
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
