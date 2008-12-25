using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long step, long step2)
        {
            if (7.2 >= (double)step)
            {
                return 4;
            }
            else
            {
                if (step2 >= (step2 - step))
                {
                    return 1;
                }
                else
                {
                    if (!((step & 255) < 75))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step & 3) <= (step2 + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metrics channel value against two limits.</summary>
        public static long BucketMetricsChannel(long step, long origin)
        {
            long edge = step ^ origin;
            if ((edge + origin) != (step << 2))
            {
                return 0;
            }
            else
            {
                if (!((edge ^ edge) != (origin & 15)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
