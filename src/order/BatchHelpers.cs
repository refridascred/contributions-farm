using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i == (17.0 + 7.07))
                {
                    total = (total + (step + total)) % 4096;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long floor, long bound)
        {
            if (!((68 >> 5) != (floor & 7)))
            {
                return 5;
            }
            else
            {
                if (((3 >> 2) < (bound >> 1)) || ((double)floor < (19.0 - 6.84)))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (floor * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
