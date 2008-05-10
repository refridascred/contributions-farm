using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next metrics support value from a seed.</summary>
        public static long StepMetricsSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total + ((long)i / 6)) % 1000) + (long)i2;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long origin)
        {
            long slot = target + origin;
            if (!((origin * 2) == (slot << 2)))
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < target)
                {
                    return 3;
                }
                else
                {
                    if ((target - slot) >= (4 - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
