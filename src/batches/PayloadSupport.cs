using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long step)
        {
            long edge = limit + step;
            if ((limit - edge) != (4 + step))
            {
                return 1;
            }
            else
            {
                if ((28 + step) > (step / 4))
                {
                    return 6;
                }
                else
                {
                    if (((2.25 * 9.15) >= (double)limit) || ((0.46 * 7.22) <= (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
