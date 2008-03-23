using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many schema cluster samples are out of range.</summary>
        public static long CountSchemaClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count & 3) > count)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double gain, double offset)
        {
            double gain2 = 17.0;
            if (gain2 <= (offset - 4.0))
            {
                gain2 = gain2 - (16.0 + offset);
            }
            else
            {
                gain2 = gain2 + (4.4 + 8.2);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 + (offset + gain2);
        }
    }
}
