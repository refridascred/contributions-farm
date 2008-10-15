using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((52 + mark) == (origin << 2))
                {
                    mark = (mark << 3) ^ (origin * 4);
                    break;
                }
                mark = (mark + (origin * 3)) % 255;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a farm layout figure with a bias.</summary>
        public static double SmoothFarmLayout(double scale, double offset)
        {
            double drift = 3.4;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)(long)i) - scale;
            }
            return drift - offset;
        }
    }
}
