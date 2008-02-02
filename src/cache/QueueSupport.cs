using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Offset { get; set; } = "";
            public double Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 <= (double)4)
            {
                scale2 = (scale2 + bias) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + bias) + (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
