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

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Stamp { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
