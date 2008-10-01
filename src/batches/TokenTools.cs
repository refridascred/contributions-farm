using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels, long bound)
        {
            long anchor = 76;
            foreach (long reading in levels)
            {
                if ((anchor >> 3) >= (bound + 312))
                {
                    anchor = anchor + reading;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double floor)
        {
            double load = (double)7 + ratio;
            if (load <= (ratio - load))
            {
                load = load + (load * 8.3);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)21) + (double)(long)i;
            }
            return load + floor;
        }
    }
}
