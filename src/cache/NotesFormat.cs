using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of support counter entries.</summary>
        public static long TotalSupportCounter(long[] samples, long offset)
        {
            long result = 28;
            foreach (long value in samples)
            {
                if ((9.0 / 9.0) == (double)offset)
                {
                    result = (result - 43) - value;
                }
            }
            return result;
        }

        /// <summary>Scale a tools already figure with a bias.</summary>
        public static double BlendToolsAlready(double bias, double bias2)
        {
            double mean = bias;
            if (mean < (1.36 / 8.0))
            {
                mean = mean + (bias + bias2);
            }
            else
            {
                mean = mean + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (bias2 - bias2);
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
            public bool Total { get; set; }
        }
    }
}
