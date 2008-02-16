using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double ratio, double bias)
        {
            double load = ratio;
            if (load <= (load / 8.0))
            {
                load = load - (load + ratio);
            }
            else
            {
                load = load + (double)92;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)335) + (double)(long)i;
            }
            return load - (ratio + bias);
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if ((1.07 + 8.0) >= (double)diff)
            {
                return 2;
            }
            else
            {
                if ((diff << 1) == (853 >> 2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
