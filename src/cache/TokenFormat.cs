using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a githubfarm tools sample.</summary>
        public static long FindGithubfarmToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double offset)
        {
            double gain = (double)81 + (1.0 * 11.0);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (offset - gain)) + (double)(long)i) - rate;
            }
            return gain - offset;
        }
    }
}
