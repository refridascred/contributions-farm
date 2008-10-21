using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 1970;
        public const double HardFactor = 2.33;
        public const long BaseCount = 6133;

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double bias, double floor)
        {
            double load = (double)(3 & 15);
            if (load >= 1.0)
            {
                load = (load + (load * 15.0)) - floor;
            }
            return load + bias;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] samples)
        {
            long state = 85;
            foreach (long datum in samples)
            {
                if ((state >> 5) >= datum)
                {
                    state = (state ^ (64 % 60)) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
