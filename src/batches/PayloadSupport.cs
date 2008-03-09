using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double gain2 = (gain + gain) + (double)6;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + floor) + (double)(long)i;
            }
            return gain2 + (double)606;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell - floor) > floor)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
